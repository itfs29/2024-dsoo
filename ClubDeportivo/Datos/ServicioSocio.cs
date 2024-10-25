using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class ServicioSocio
    {
        public bool registrar(E_Socio socio)
        {
            try
            {
                ServicioConexion connection = ServicioConexion.getInstancia();
                MySqlCommand comando = new MySqlCommand("registrarSocio");
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("tipodoc", MySqlDbType.VarChar).Value = socio.TipoDoc;
                comando.Parameters.Add("documento", MySqlDbType.VarChar).Value = socio.Documento;
                comando.Parameters.Add("tipocliente", MySqlDbType.Int16).Value = 1;
                comando.Parameters.Add("aptofisico", MySqlDbType.Bit).Value = socio.AptoFisico;
                DataTable dataTable = connection.ejecutar(comando);
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }
    }
}
