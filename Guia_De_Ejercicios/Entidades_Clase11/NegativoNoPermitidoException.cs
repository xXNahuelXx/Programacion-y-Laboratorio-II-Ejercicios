using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase11
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException(string message) : base(message)
        {

        }

        public NegativoNoPermitidoException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
