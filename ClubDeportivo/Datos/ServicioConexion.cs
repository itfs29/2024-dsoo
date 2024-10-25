using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace ClubDeportivo.Datos
{
    public class ServicioConexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private MySqlConnection sqlCon;
        private static ServicioConexion instancia = null;
        private ServicioConexion()
        {
            this.baseDatos = "ClubDeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }

        public MySqlConnection CrearConexion()
        {

            sqlCon = new MySqlConnection();

            try
            {
                sqlCon.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
                sqlCon.Open();

            }
            catch (Exception e)
            {
                sqlCon = null;
                throw;
            }

            return sqlCon;
        }
        public void cerrarConexion()
        {
            if(sqlCon!=null && sqlCon.State==ConnectionState.Open)
                sqlCon.Close();
        }

        public static ServicioConexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ServicioConexion();
                instancia.CrearConexion();
            }
            return instancia;
        }

        public DataTable ejecutar(MySqlCommand comando)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            comando.Connection = sqlCon;
            comando.CommandType = CommandType.StoredProcedure;
            resultado = comando.ExecuteReader();
            tabla.Load(resultado);
            return tabla;   
        }

        
    }
}

