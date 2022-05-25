using System;
using Entidades_Clase13;

namespace Ejercicio1_Cartuchera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            CartucheraSimple cartuSimple = new CartucheraSimple();
            CartucheraMultiUso cartuMultiUso = new CartucheraMultiUso();

            cartuSimple.boligrafos.Add(miBoligrafo);
            cartuSimple.lapices.Add(miLapiz);

            cartuMultiUso.acciones.Add(miBoligrafo);
            cartuMultiUso.acciones.Add(miLapiz);

            Console.WriteLine(cartuSimple.RecorrerElementos());
            Console.WriteLine(cartuMultiUso.RecorrerElementos());

            Console.ReadKey();
        }
    }
}
