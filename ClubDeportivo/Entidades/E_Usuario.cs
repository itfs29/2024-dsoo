using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Usuario
    {
        private string usuario;
        private string password;

        public E_Usuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
    }
}
