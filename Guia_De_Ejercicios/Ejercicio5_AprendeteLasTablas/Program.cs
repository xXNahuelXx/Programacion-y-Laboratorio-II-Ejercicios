using System;
using System.Text;

namespace Ejercicio5_AprendeteLasTablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine(Program.Tablas(numero));
        }

        public static string Tablas(int numero)
        {
            StringBuilder sb = new StringBuilder();

            for(int i=1;i<=9;i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }
            return sb.ToString();
        }
    }
}
