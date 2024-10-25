using ClubDeportivo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Persona
    {
        public static string[] tipoDocs = { "DNI", "CEDULA", "CUIL" };
        private int id;
        private string nombre;
        private string apellido;
        private string tipoDoc;
        private string documento;

        public E_Persona(string nombre, string apellido,string tipoDoc, string documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipoDoc;
            Documento = documento;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre
        {
            get => nombre;
            set
            {
                if (value.Length > 50)
                {
                    throw new ExcepcionGeneral("Nombre demasiado largo");
                }else if (value.Length == 0)
                {
                    throw new ExcepcionGeneral("Error en nombre");
                }
                nombre = value;
            }
        }
        public string Apellido
        {
            get => apellido;
            set
            {
                if (value.Length > 50)
                {
                    throw new ExcepcionGeneral("Apellido demasiado largo");
                }
                else if (value.Length == 0)
                {
                    throw new ExcepcionGeneral("Error en apellido");
                }
                apellido = value;
            }
        }
        public string TipoDoc { 
            get => tipoDoc; 
            set
            {
                tipoDoc = "";
                foreach(string tipo in tipoDocs)
                {
                    if (value.Equals(tipo))
                    {
                        tipoDoc = value;
                        return;
                    }
                }
                if(tipoDoc.Length==0)
                    throw new ExcepcionGeneral("Error en tipo de documento");
            }
        }
        public string Documento
        {
            get => documento;
            set
            {
                if (value.Length > 11)
                {
                    throw new ExcepcionGeneral("Documento demasiado largo");
                }
                else if (value.Length == 0)
                {
                    throw new ExcepcionGeneral("Error en documento");
                }
                documento = value;
            }
        }
    }
}
