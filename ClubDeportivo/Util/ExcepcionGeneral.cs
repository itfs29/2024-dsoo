using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Util
{
    internal class ExcepcionGeneral: Exception
    {
        public ExcepcionGeneral(string mensaje):base(mensaje) { 
            
        }

        public ExcepcionGeneral(string mensaje,Exception e) : base(mensaje,e)
        {

        }

    }
}
