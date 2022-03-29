using System;

namespace Ejercicio4_UnNumeroPerfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador;
            for (int i = 6; i <= 8128; i++)
            {
                acumulador = 0;
                for (int j = i - 1; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if (acumulador == i)
                {
                    Console.WriteLine($"Numero perfecto: {i}");
                }
            }
        }
    }
}
