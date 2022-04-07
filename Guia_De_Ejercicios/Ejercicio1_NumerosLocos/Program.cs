using System;

namespace Ejercicio1_NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random random = new Random();

            Console.WriteLine("Array original");
            for(int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine(arrayNumeros[i]=random.Next(-100,100));
            }

            Array.Sort(arrayNumeros,Program.OrdenDescendente);
            Console.WriteLine("Array Ordenado Descendente");
            for (int i = 0;i < arrayNumeros.Length;i++)
            {
                if(arrayNumeros[i]>0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }

            Array.Sort(arrayNumeros, Program.OrdenAscendente);
            Console.WriteLine("Array Ordenado Ascendente");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }
        }
        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }

        public static int OrdenAscendente(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
