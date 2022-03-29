using System;
using EntidadesClase3;

namespace Ejercicio3_ElEjemploUniversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Nahuel","Ghigliotti","106161");
            Estudiante e2 = new Estudiante("Oliver", "Atom", "15958");
            Estudiante e3 = new Estudiante("Richar", "Asspero", "158745");

            e1.SetNotaPrimerParcial(8);
            e1.SetNotaSegundoParcial(9);
            e2.SetNotaPrimerParcial(7);
            e2.SetNotaSegundoParcial(7);
            e3.SetNotaPrimerParcial(3);
            e3.SetNotaSegundoParcial(5);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}
