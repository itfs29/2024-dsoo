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
    internal class ServicioNoSocio
    {
        public bool registrar(E_NoSocio noSocio)
        {
            try
            {
                ServicioConexion connection = ServicioConexion.getInstancia();
                MySqlCommand comando = new MySqlCommand("registrarSocio");
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("tipodoc", MySqlDbType.Int16).Value = noSocio.TipoDoc;
                comando.Parameters.Add("documento", MySqlDbType.VarChar).Value = noSocio.Documento;
                comando.Parameters.Add("tipocliente", MySqlDbType.Int16).Value = 0;
                comando.Parameters.Add("aptofisico", MySqlDbType.Bit).Value = noSocio.AptoFisico;
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
