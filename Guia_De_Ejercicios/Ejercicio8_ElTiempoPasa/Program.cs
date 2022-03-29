using System;

namespace Ejercicio8_ElTiempoPasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            Console.Write("Ingrese una fecha pasada para calcular los dias transcurridos a hoy: ");
            DateTime.TryParse(Console.ReadLine(), out fecha);
            CalcularDias(fecha);
        }

        public static void CalcularDias(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;
            if (fecha<fechaActual)
            {
                DateTime fechaInicial = fecha;

                TimeSpan fechaTotal = fechaActual - fechaInicial;
                Console.WriteLine($"Pasaron {fechaTotal} dias");
            }

        }
    }
}
