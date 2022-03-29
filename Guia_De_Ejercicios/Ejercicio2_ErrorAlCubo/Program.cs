using System;

namespace Ejercicio2_ErrorAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Ingresar un numero para mostrar su cuadrado y su cubo: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero < 0)
                {
                    Console.WriteLine("ERROR.¡Reingresar número!");
                }
            } while (numero <= 0);

            Console.WriteLine($"\n{numero}^2: {Math.Pow(numero, 2)}\n{numero}^3: {Math.Pow(numero, 3)}");
        }
    }
}
