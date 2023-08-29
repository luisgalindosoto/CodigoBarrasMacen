using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
namespace brc_tags.Librerias
{
	public class conexion
	{
		/******************************************************************/
        /*
            Nombre Libreria:    conexion
            Fecha Creacion:     04/11/2015
            Desarrollador:      Luis Galindo
         
            Fecha Modificacion: 09/11/2015
            Modificacion:       Se agrego metodos para poder armar la conexion del App.config
            Desarrollador:      Luis Galindo
         */
        /******************************************************************/
        //Librerias para leer un archivo ini
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        //Variables privadas de la conexion
        private string DB;
        private string Server;
        private string Usuario;
        private string Password;

        //Metodo para Obtener una valor de una configurcion de un archivo ini

        public string ObtenerConfiguracionIni(string Ruta, string NodoPadre , string NodoHijo){
            string valor = "";

            StringBuilder cantidad = new StringBuilder(100);
            
            string archivo = Ruta;
            if (File.Exists(archivo))
            {
                
               GetPrivateProfileString(NodoPadre,
                                             NodoHijo,
                                             "",
                                             cantidad,
                                             cantidad.Capacity,
                                             archivo);
                valor = cantidad.ToString();
            }
            
            return valor;
        }


        //Metodo que asgina la base de datos a la clase conexion
        public void SetDB(string _DB) {
            DB = _DB;
        }
        //Metodo que asigna el servidor de la conexion
        public void SetServer(string _Server)
        {
            Server = _Server;
        }
        //Metodo que asignar el usuario de la conexion
        public void SetUsuario(string _Usuario)
        {
            Usuario = _Usuario;
        }
        //Metodo que asigna la contraseña de la conexion
        public void SetPassword(string _Password)
        {
            Password = _Password;
        }
        //Metodo que obtienen el nombre de la base de datos de la conexion
        public string GetDB( )
        {
           return DB;
        }
        //Metodo que obtiene el nombre del servidor de la conexion
        public string GetServer()
        {
           return Server;
        }
        //Metodo que obtienen el nombre de usuario de la conexion
        public string GetUsuario()
        {
           return Usuario ;
        }
        //Metodo que obtienen el password de la conexion
        public string GetPassword()
        {
           return Password;
        }

        //Obtiene la cadena de conexion de una configuracion del App.config
        public string GetAppConfigConnectionString(string connectionStringName)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[connectionStringName];
            return connStringSettings.ConnectionString;
        }
        //Metodo que guarda una nueva configuracion al App.config
        public void SaveExeConfigurationAppConfigConnectionString(string connectionStringName, string connectionString)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            appconfig.ConnectionStrings.ConnectionStrings[connectionStringName].ConnectionString = connectionString;
           // appconfig.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            appconfig.Save();
        }
        //Metodo que guarda una nueva configuracion al App.config
        public void SaveMachineConfigurationAppConfigConnectionString(string connectionStringName, string connectionString)
        {
            Configuration appconfig2 =
                ConfigurationManager.OpenMachineConfiguration();
            appconfig2.ConnectionStrings.ConnectionStrings[connectionStringName].ConnectionString = connectionString;
            appconfig2.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            appconfig2.Save();


        }
        //Metodo que encripta el archivo App.config
        public void CriptConfigurationAppConfigConnctionString() {

            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            conf.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            conf.Save();
        }
        //Metodo que obtienen la lista de configuraciones del App.config
        public List<string> GetAppConfigConnectionStringNames()
        {
            List<string> cns = new List<string>();
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (ConnectionStringSettings cn in appconfig.ConnectionStrings.ConnectionStrings)
            {
                cns.Add(cn.Name);
            }
            return cns;
        }
        //Metodo que obitnene el nombre de la primera configuracion del App.config
        public string GetAppConfigFirstConnectionStringName()
        {
            return GetAppConfigConnectionStringNames().FirstOrDefault();
        }
        //Metodo que obtienen la primera configuracion del App.config
        public string GetFirstConnectionString()
        {
            return GetAppConfigConnectionString(GetAppConfigFirstConnectionStringName());
        }

        //Metodo que obtiene el nombre del servidor de la primera configuracion del App.config
        public string GetSqlServerServerName()
        {
            string cs = GetAppConfigConnectionString(GetAppConfigFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.DataSource;
            }
            else
                return null;
        }
        //Metodo que obtiene el nombre de la base de datos de la primera configuracion del App.config
        public string GetSqlServerDatabaseName()
        {
            string cs = GetAppConfigConnectionString(GetAppConfigFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.InitialCatalog;
            }
            else
                return null;
        }
        //Metodo que obtienen el nombre de usuario de la primera configuracion del App.config
        public string GetSqlServerUserName()
        {
            string cs = GetAppConfigConnectionString(GetAppConfigFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.UserID;
            }
            else
                return null;
        }
        //Metodo que obtienen le contraseña de la primera configuracion del App.config
        public string GetSqlServerPassword()
        {
            string cs = GetAppConfigConnectionString(GetAppConfigFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.Password;
            }
            else
                return null;
        }

       

        //Metodo que manda el nombre del servidor a la configuracion App.config
        public string SetConnectionStringServerName(
            string connectionString, string serverName)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.DataSource = serverName;
            return builder.ConnectionString;
        }

        //Metodo que indica si lleva o no la autenticacion integrada a la configuracion App.config
        public string SetConnectionStringAutenticationIntegrated(
            string connectionString)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

        //Metodo que manda la autenticacion de la configuracion App.config
        public string SetConnectionStringAutenticationSQLServer(
            string connectionString, string username, string password)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = false;
            builder.UserID = username;
            builder.Password = password;
            return builder.ConnectionString;
        }

        //Metodo que manda el nombre de la base de datos a las configuracion App.config
        public string SetConnectionStringDatabaseName(
            string connectionString, string databaseName)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.InitialCatalog = databaseName;
            return builder.ConnectionString;
        }
		
        //Metodo que ejecuta una consulta y deveulve un DataSet
        public DataSet consultaSelect(string cadenaConsulta, string cadenaTabla, ref string Respuesta)
		{
            Respuesta = "";
            string ConnString = "server=" + Server + ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
            SqlConnection conexionSQL = new SqlConnection(ConnString);
			DataSet dataSet = new DataSet();
			try {
			    
                SqlDataAdapter selectData = new SqlDataAdapter(cadenaConsulta, conexionSQL);
				selectData.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				selectData.FillSchema(dataSet, SchemaType.Source, cadenaTabla);
				selectData.Fill(dataSet, cadenaTabla);
                conexionSQL.Close();
                Respuesta = "Completado";
			} catch(Exception ex) {
                Respuesta = "Ocurrio un error:" + ex.Message.ToString();
                if (conexionSQL.State == ConnectionState.Open)
                {
                    conexionSQL.Close();
                }
			}
			//Devuelve tabla con consulta realizada
			return dataSet;
		}

		//Metodo que realiza una busqueda y devuelve un valor verdadero o falso
		public bool busqueda(string cadenaBusqueda, ref string Respuesta)
        {
           
            bool resultado = new bool();
            Respuesta = "";
            string ConnString = "server=" + Server + ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
            SqlConnection conexionSQL = new SqlConnection(ConnString);
			try {
				SqlCommand sqlCommand = new SqlCommand(cadenaBusqueda, conexionSQL);
				var sqlReader = sqlCommand.ExecuteReader();
				sqlReader.Close();
                if (sqlReader.HasRows)
                {
                    //Consulta encontrada
                    resultado = true;
                }
                else
                {
                    //Consulta no encontrada
                    resultado = false;
                }
				sqlCommand.Parameters.Clear();
                Respuesta = "Completado";
            }
            catch (Exception ex)
            {
                Respuesta = "Ocurrio un error:" + ex.Message.ToString();
                if (conexionSQL.State == ConnectionState.Open)
                {
                    conexionSQL.Close();
                }
            }
            return resultado;
			//Devuelve parametro de estado de consulta
			
		}

		//Metodo que ejecuta un query
		public void insertar(string cadenaInsertar, ref string Respuesta)
        {
            Respuesta = "";
            string ConnString = "server=" + Server + ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
            SqlConnection conexionSQL = new SqlConnection(ConnString);
			try {
                conexionSQL.Open();
				SqlCommand sqlCommand = new SqlCommand(cadenaInsertar, conexionSQL);
				sqlCommand.ExecuteNonQuery();
				sqlCommand.Parameters.Clear();
                conexionSQL.Close();
                Respuesta = "Completado";
            }
            catch (Exception ex)
            {
                Respuesta = "Ocurrio un error:" + ex.Message.ToString();
                if (conexionSQL.State == ConnectionState.Open)
                {
                    conexionSQL.Close();
                }
                
            }
			//Devuelve parametro de estado de ingreso
			
		}



		//Metodo que busca un registro
		public string busquedaID(string cadenaBusqueda, string busquedaRow, ref string Respuesta)
        {
            Respuesta = "";
            string ConnString = "server=" + Server + ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
            SqlConnection conexionSQL = new SqlConnection(ConnString);
			string resultado = "";
			try {
				SqlCommand sqlCommand = new SqlCommand(cadenaBusqueda, conexionSQL);
				var sqlReader = sqlCommand.ExecuteReader();
				if (sqlReader.Read()) {
					resultado = sqlReader[busquedaRow].ToString();
                 
					//Consulta encontrada
				}
				sqlCommand.Parameters.Clear();
				sqlReader.Close();
                Respuesta = "Completado";
            }
            catch (Exception ex)
            {
                Respuesta = "Ocurrio un error:" + ex.Message.ToString();

                if (conexionSQL.State == ConnectionState.Open)
                {
                    conexionSQL.Close();
                }
                
			}
			//Devuelve parametro de consulta
			return resultado;
		}


        //Metodo que ejecuta un query tipo escalar
        public string ejecutaEscalar(string pSQL, ref string Respuesta)
        {
            Respuesta = "";
            string pResultado = "";
            string ConnString = "server=" + Server+ ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
            SqlConnection ConnSql = new SqlConnection(ConnString);
         

            try
            {
                    SqlCommand CmdSql = new SqlCommand();
                    CmdSql.Connection = ConnSql;
                    if (ConnSql.State == ConnectionState.Closed)
                        ConnSql.Open();
                    CmdSql.CommandType = CommandType.Text;
                    CmdSql.CommandText = pSQL;
                    pResultado = CmdSql.ExecuteScalar().ToString();
                    ConnSql.Close();
                    Respuesta = "Completado";
            }
            catch (Exception ex)
            {
                pResultado = "";
                Respuesta =  "Ocurrio un error:" + ex.Message.ToString();
                    if (ConnSql.State == ConnectionState.Open)
                    {
                        ConnSql.Close();
                    }
                
            
            }
            return pResultado;
        }


        //Metodo que devuelve un dataview de una consulta
        public  void cargarVista(string Sql, ref DataView Dv,ref string Respuesta )
        {
            bool functionReturnValue = false;
            DataSet Ds = new DataSet();
            Respuesta = "";
            string pResultado = "";
            string ConnString = "server=" + Server + ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
            SqlConnection Conn1 = new SqlConnection(ConnString);
         

            try
            {

                    SqlCommand Cmd1 = new SqlCommand();
                    Cmd1.Connection = Conn1;
                    if (Conn1.State == ConnectionState.Closed)
                        Conn1.Open();
                    Cmd1.CommandText = Sql;
                    Cmd1.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(Cmd1);
                    SqlDataAdapter prv_Ds = new SqlDataAdapter(Cmd1);
                    da.Fill(Ds);
                    Conn1.Close();

                    Conn1.Dispose();
                    Cmd1.Dispose();
                    Dv = Ds.Tables[0].DefaultView;
                    Respuesta = "Completado";
            }
            catch (Exception ex)
            {
                pResultado = "";
                Respuesta = "Ocurrio un error:" + ex.Message.ToString();
                if (Conn1.State == ConnectionState.Open)
                {
                    Conn1.Close();
                }


            }
         
         

        }

        //Metodo que permite ejecutar una matriz de querys
        public  bool runSqlMatriz(ArrayList pvx_Sql, ref string Respuesta)
        {

            
            Respuesta = "";
            bool functionReturnValue = false;
            int I = 0;
            string vlc_Sql = null;
          
            try
            {
                    string ConnString = "server=" + Server + ";database=" + DB + ";uid=" + Usuario + ";pwd=" + Password + ";";
                    SqlConnection myConnection1 = new SqlConnection(ConnString);
                    SqlCommand Cmd1 = new SqlCommand();
                    myConnection1.Open();
                    SqlTransaction myTrans1 = myConnection1.BeginTransaction();
                    SqlCommand myCommand = myConnection1.CreateCommand();
                    myCommand.Transaction = myTrans1;
                    try
                    {
                        for (I = 0; I <= (pvx_Sql.Count - 1); I++)
                        {
                            vlc_Sql = pvx_Sql[I].ToString();
                            myCommand.CommandText = vlc_Sql;
                            myCommand.ExecuteNonQuery();
                        }
                        myTrans1.Commit();
                        Respuesta = "Completado";
                    }
                    catch (Exception ex)
                    {
                        Respuesta = "Ocurrio un error:" + ex.Message.ToString();
                        myTrans1.Rollback();
                        myConnection1.Close();
                        throw ex;
                    }

                    functionReturnValue = true;

                    myConnection1.Dispose();

            }
            catch (Exception e)
            {
                functionReturnValue = false;


            }
          
            return functionReturnValue;

        }

	}
}

