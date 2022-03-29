using System;

namespace Ejercicio7_PitagorasEstariaOrgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double _base;
            double altura;

            Console.Write("Ingrese la base del triangulo en centimetros: ");
            double.TryParse(Console.ReadLine(), out _base);

            Console.Write("Ingrese la altura de un triangulo en centimetros: ");
            double.TryParse(Console.ReadLine(), out altura);
        }
    }
}
