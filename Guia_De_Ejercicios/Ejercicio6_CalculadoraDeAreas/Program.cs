using System;

namespace Ejercicio6_CalculadoraDeAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitudLadoCuadrado;
            double _base;
            double altura;
            double radio;

            Console.Write("Ingrese el lado de un cuadrado para calcular su area: ");
            double.TryParse(Console.ReadLine(), out longitudLadoCuadrado);
            Console.WriteLine($"El area del cuadrado es: {CalculadoraDeAreas.CalcularAreaCuadrado(longitudLadoCuadrado)}\n");

            Console.Write("Ingrese la base del triangulo: ");
            double.TryParse(Console.ReadLine(), out _base);

            Console.Write("Ingrese la altura de un triangulo: ");
            double.TryParse(Console.ReadLine(), out altura);
            Console.WriteLine($"El area de un triangulo es: {CalculadoraDeAreas.CalcularAreaTriangulo(_base, altura)}\n");

            Console.Write("Ingrese el radio del circulo para calcular su area: ");
            double.TryParse(Console.ReadLine(), out radio);
            Console.WriteLine($"El area de un circulo es: {CalculadoraDeAreas.CalcularAreaCirculo(radio)}\n");
        }
    }
}
