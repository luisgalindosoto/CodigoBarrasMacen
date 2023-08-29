using brc_tags.Librerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class ValidarCredenciales : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string IdTipoPlantilla;
        public string Respuesta;
        public ValidarCredenciales()
        {
            InitializeComponent();
        }

        private void ValidarCredenciales_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try {

                string ValidarUsuario = "";
                string ValidarPass="";

                               
                if (!string.IsNullOrEmpty(Convert.ToString(txt_pass.EditValue)))
                    ValidarPass = txt_pass.EditValue.ToString();

                if (!string.IsNullOrEmpty(Convert.ToString(txt_usuario.EditValue)))
                    ValidarUsuario = txt_usuario.EditValue.ToString();

                if (string.IsNullOrEmpty(ValidarPass))
                {
                    MessageBox.Show("Debe de ingresar un pasword para validar.!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(ValidarUsuario))
                {
                    MessageBox.Show("Debe de ingresar un usuario para validar.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(ValidarUsuario);
                consulta.SetPassword(ValidarPass);
                consulta.SetServer(Server);
                string ControlError = "";


                string ExisteValidacion = "";
                ExisteValidacion = consulta.ejecutaEscalar("SELECT ISNULL(VALIDA,'N') FROM "+DB+".DBO.BRC_USUARIO_DEPARTAMENTO WHERE ID_USUARIO='"+User_id+"' AND ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"'", ref ControlError);

                if (ControlError == "Completado")
                {
                    if (ExisteValidacion == "Y")
                    {
                        Respuesta = "OK";
                    }
                    else {
                        Respuesta = "CANCEL";
                    }

                }
                else {
                    MessageBox.Show("Ocurrio un error favor contactaru su administrador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                this.Close();
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
