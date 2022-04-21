using System;
using System.Collections.Generic;
using System.Text;
using Entidades_Clase9;

namespace Ejercicio2_CalculadoraDeFormas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            StringBuilder sb = new StringBuilder();

            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(2));
            figuras.Add(new Rectangulo(4,8));

            foreach (Figura figura in figuras)
            {
                sb.AppendLine();
                sb.AppendFormat("=============== FIGURA {0:0#} ==================\n", figuras.IndexOf(figura) + 1);
                sb.AppendFormat(" Tipo: {0}\n", figura.GetType());
                sb.AppendFormat(" {0}\n", figura.Dibujar());
                sb.AppendFormat(" Área: {0:0.00}\n", figura.CalcularSuperficie());
                sb.AppendFormat(" Perímetro: {0:0.00}\n", figura.CalcularPerimetro());
                sb.AppendLine("============================================");
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
