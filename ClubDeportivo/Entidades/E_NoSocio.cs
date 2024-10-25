using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_NoSocio:E_Persona
    {
        private bool aptoFisico;

        public E_NoSocio(string nombre, string apellido, string tipoDoc, string documento, bool aptoFisico):
            base(nombre, apellido, tipoDoc, documento)
        {
            this.AptoFisico = aptoFisico;
        }

        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    }
}
