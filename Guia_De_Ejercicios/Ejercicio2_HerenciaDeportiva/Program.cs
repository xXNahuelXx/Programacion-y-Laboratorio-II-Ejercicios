using System;
using Entidades_Clase8;

namespace Ejercicio2_HerenciaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);
            DirectorTecnico dt1 = new DirectorTecnico("nomDt1", DateTime.Parse("20/05/1998")); // new DateTime(1998,05,20);
            DirectorTecnico dt2 = new DirectorTecnico("nomDt2", DateTime.Parse("10/02/1979"));
            dt1.Dni = 41026881;
            dt2.Dni = 42152365;

            Console.WriteLine(dt1.MostrarDatos());
            Console.WriteLine(dt2.MostrarDatos());

            Console.WriteLine(dt1==dt2);

            if (equipo + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }


            if (equipo + j2)
            {
                Console.WriteLine(j2.MostrarDatos());
            }


            if (equipo + j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO:\n" + j3.MostrarDatos());
            }

            if (equipo + j4)
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO:\n" + j4.MostrarDatos());
            }
        }
    }
}
