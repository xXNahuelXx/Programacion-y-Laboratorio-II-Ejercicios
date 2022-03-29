using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_CalculadoraDeAreas
{
    public class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double _base, double altura) 
        {
            return (_base * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return 3.14F*Math.Pow(radio, 2);
        }
    }
}
