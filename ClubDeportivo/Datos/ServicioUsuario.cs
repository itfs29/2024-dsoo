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
    internal class ServicioUsuario
    {
        public bool login(E_Usuario usuario)
        {
            try
            {
                ServicioConexion connection = ServicioConexion.getInstancia();
                MySqlCommand comando = new MySqlCommand("login");
                comando.Parameters.Add("usuario", MySqlDbType.VarChar).Value = usuario.Usuario;
                comando.Parameters.Add("password", MySqlDbType.VarChar).Value = usuario.Password;
                DataTable dataTable = connection.ejecutar(comando);
                if (dataTable == null || dataTable.Rows.Count <= 0)
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }
    }
}
