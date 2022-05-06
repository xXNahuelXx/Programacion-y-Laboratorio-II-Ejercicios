using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase10
{
    public static class Calculador
    {
        public static float Calcular(int num1,int num2)
        {
            if(num2==0)
            {
                throw new DivideByZeroException("No se puede dividir por 0");
            }
            return (float)num1 / num2;
        }
    }
}
