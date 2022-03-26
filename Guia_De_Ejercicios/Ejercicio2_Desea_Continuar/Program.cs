using System;
using Validaciones;

namespace Ejercicio2_Desea_Continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int numero;
            int acumulador = 0;

            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero para sumar: ");
                int.TryParse(Console.ReadLine(), out numero);

                acumulador += numero;
                Console.WriteLine($"{acumulador}");

                Console.Write("¿Desea continuar? (S/N): ");
                char.TryParse(Console.ReadLine(), out respuesta);

            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
