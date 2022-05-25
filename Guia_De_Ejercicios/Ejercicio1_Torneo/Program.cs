using System;
using Entidades_Clase12;

namespace Ejercicio1_Torneo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFuchibol = new Torneo<EquipoFutbol>("ChampionsLeague");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            EquipoFutbol equipitoFut1 = new EquipoFutbol("Barcelona", new DateTime(1913, 05, 20));
            EquipoFutbol equipitoFut2 = new EquipoFutbol("Independiente", new DateTime(1916, 04, 23));
            EquipoFutbol equipitoFut3 = new EquipoFutbol("Real Madrid", new DateTime(1920, 02, 10));

            EquipoBasquet equipitoBasq1 = new EquipoBasquet("Spurs", new DateTime(1918, 12, 06));
            EquipoBasquet equipitoBasq2 = new EquipoBasquet("Bulls", new DateTime(1920, 8, 08));
            EquipoBasquet equipitoBasq3 = new EquipoBasquet("Lakers", new DateTime(1918, 05, 29));

            torneoFuchibol += equipitoFut1;
            torneoFuchibol += equipitoFut2;
            torneoFuchibol += equipitoFut3;
            torneoBasquet += equipitoBasq1;
            torneoBasquet += equipitoBasq2;
            torneoBasquet += equipitoBasq3;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"\nTorneo Futbol: {torneoFuchibol.Mostrar()}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"\nTorneo Basket: {torneoBasquet.Mostrar()}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(torneoFuchibol.JugarPartido);
            Console.WriteLine(torneoFuchibol.JugarPartido);
            Console.WriteLine(torneoFuchibol.JugarPartido);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
