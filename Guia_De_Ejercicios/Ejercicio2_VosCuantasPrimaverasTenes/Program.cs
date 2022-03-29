using System;
using EntidadesClase3;
namespace Ejercicio2_VosCuantasPrimaverasTenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Nahuel", new DateTime(1998, 05, 20), "41.026.881");
            Persona p2 = new Persona("Ricardo", new DateTime(1999, 02, 04), "41.235.432");
            Persona p3 = new Persona("Asspero", new DateTime(2008, 08, 13), "58.033.256");

            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p3.Mostrar());
        }
    }
}
