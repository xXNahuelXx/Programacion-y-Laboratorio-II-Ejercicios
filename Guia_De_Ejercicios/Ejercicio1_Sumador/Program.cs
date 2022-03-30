using System;
using Entidades_Clase4;

namespace Ejercicio1_Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(2);

            Console.WriteLine(s1.Sumar(5,3));
            Console.WriteLine(s2.Sumar("8","3"));
            Console.WriteLine((int)s1);
            Console.WriteLine((int)s2);
            Console.WriteLine(s1|s2);
            Console.WriteLine(s1+s2);

        }
    }
}
