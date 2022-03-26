using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Validador
    {
        public static bool Validar(int valor,int min,int max)
        {
            return valor >= min && valor <= max;
        }

        public static bool ValidarRespuesta(char respuesta)
        {
            return respuesta == 's';
        }
    }
}
