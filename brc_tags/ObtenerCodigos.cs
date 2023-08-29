using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class ObtenerCodigos : Form
    {
        public string ResetearLectura;
        public string Respueta;
        public ArrayList CodigosInformacionMaquina;
       
        public ArrayList CodigosTurnos;

        public ArrayList DefaultInformacionMaquina;
        public ArrayList DefaultTurnos;
        public ObtenerCodigos()
        {
            InitializeComponent();
        }

        private void ObtenerCodigos_Load(object sender, EventArgs e)
        {
            CodigosInformacionMaquina = new ArrayList();
            
            CodigosTurnos = new ArrayList();
            Respueta = "";

            if (DefaultInformacionMaquina == null)
                DefaultInformacionMaquina = new ArrayList();

            if (DefaultTurnos == null)
                DefaultTurnos = new ArrayList();



            if (DefaultInformacionMaquina.Count > 0 && DefaultTurnos.Count > 0 && ResetearLectura=="N") {

                for (int i = 0; i < DefaultInformacionMaquina.Count; i++) {
                    lst_comandos.Items.Add("Codigo Informacion:" + DefaultInformacionMaquina[i].ToString());
                    CodigosInformacionMaquina.Add(DefaultInformacionMaquina[i].ToString());
                }

                for (int i = 0; i < DefaultTurnos.Count; i++)
                {
                    lst_comandos.Items.Add("Turno:" + DefaultTurnos[i].ToString());
                    CodigosTurnos.Add(DefaultTurnos[i].ToString());
                }

                if (CodigosInformacionMaquina.Count > 0 && CodigosTurnos.Count > 0)
                    btn_aceptar.Focus();
            }



        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (CodigosInformacionMaquina.Count == 0  || CodigosTurnos.Count == 0)
            {

                MessageBox.Show("Se necesita tango la informacion de maquinas, el tipo de paro y el turno para poder agregar el nuevo paro, favor ingresar toda la informacion necesaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Respueta = "OK";
            
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Respueta = "CANCELAR";
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string ValorTemporal = "";
                int ItemSeleccionado = 0;
                ItemSeleccionado = lst_comandos.SelectedIndex;
                ValorTemporal = lst_comandos.Items[ItemSeleccionado].ToString();

                lst_comandos.Items.RemoveAt(ItemSeleccionado);

                if (ValorTemporal.Contains("Codigo Informacion:") == true)
                {
                    CodigosInformacionMaquina.Remove(ValorTemporal.Replace("Codigo Informacion:", ""));

                }
                
                if (ValorTemporal.Contains("Turno:") == true)
                {
                    CodigosTurnos.Remove(ValorTemporal.Replace("Turno:", ""));

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                string ValorTemporal = "";
                string ValorAgregar = "";
                if (Convert.ToInt32(e.KeyValue) == 13)
                {

                    if (!string.IsNullOrEmpty(Convert.ToString(txt_codigo.EditValue)))
                    {
                        ValorTemporal = txt_codigo.EditValue.ToString().Replace("'", "-").ToUpper();
                        if (!string.IsNullOrEmpty(Convert.ToString(ValorTemporal)))
                        {
                            if (ValorTemporal.Contains("INFM") == true)
                            {
                                for (int i = 0; i < lst_comandos.Items.Count; i++)
                                {

                                    if (lst_comandos.Items[i].ToString().Contains("Codigo Informacion:") == true)
                                    {
                                        lst_comandos.Items.RemoveAt(i);
                                        CodigosInformacionMaquina.RemoveAt(i);
                                    }
                                }

                                ValorAgregar = ValorTemporal.Replace("INFM", "").ToString().Replace("-", "").ToString().Replace("'", "");
                                lst_comandos.Items.Add("Codigo Informacion:" + ValorAgregar.ToString());
                                CodigosInformacionMaquina.Add(ValorAgregar);

                            }


                            if (ValorTemporal.Contains("TURNO") == true)
                            {
                                for (int i = 0; i < lst_comandos.Items.Count; i++)
                                {

                                    if (lst_comandos.Items[i].ToString().Contains("Turno:") == true)
                                    {
                                        lst_comandos.Items.RemoveAt(i);
                                        CodigosTurnos.RemoveAt(i);

                                    }
                                }

                                ValorAgregar = ValorTemporal.Replace("TURNO", "").ToString().Replace("-", "").ToString().Replace("'", "");
                                lst_comandos.Items.Add("Turno:" + ValorAgregar.ToString());
                                CodigosTurnos.Add(ValorAgregar);
                            }
                            txt_codigo.EditValue = "";
                            txt_codigo.Focus();
                            if (CodigosInformacionMaquina.Count > 0 && CodigosTurnos.Count > 0)
                                btn_aceptar.Focus();

                        }

                    }
                    else {
                        if (CodigosInformacionMaquina.Count > 0 && CodigosTurnos.Count > 0)
                            btn_aceptar.Focus();
                    }
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactarse con el administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
