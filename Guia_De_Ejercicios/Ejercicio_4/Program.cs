using System;

namespace Ejercicio_4
{
    internal class Program
    {
        /// <summary>
        /// CONSIGNA
        /// Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
        /// El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación que encuentre los 4 primeros números perfectos.
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
           int acumulador;
           for(int i=6;i<=8128;i++)
            {
                acumulador = 0;
                for(int j=i-1;j>0;j--)
                {
                    if(i%j==0)
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
