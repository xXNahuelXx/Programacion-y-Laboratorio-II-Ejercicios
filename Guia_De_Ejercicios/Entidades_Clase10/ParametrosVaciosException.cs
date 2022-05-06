using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase10
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string mensaje):base(mensaje)
        {

        }

        public ParametrosVaciosException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }

    }
}
