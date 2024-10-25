using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Socio:E_Persona
    {
        private bool aptoFisico;

        public E_Socio(string nombre, string apellido, string tipoDoc, string documento,bool aptoFisico):
            base(nombre, apellido, tipoDoc, documento)
        {
            this.aptoFisico = aptoFisico;
        }

        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }

    }
}
