using System;
using EntidadesClase3;

namespace Ejercicio1_CreoQueNecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("Nahuel",1500);

            Console.WriteLine(c1.Mostrar());

            c1.Ingresar(500);
            Console.WriteLine($"\nIngreso: 500\n{c1.Mostrar()}");

            c1.Retirar(200);
            Console.WriteLine($"\nRetiro: 200\n{c1.Mostrar()}");

        }
    }
}
