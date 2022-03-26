using System;

namespace Ejercicio_2
{
    internal class Program
    {
        /// <summary>
        /// CONSIGNA
        /// ngresar un número y mostrar el cuadrado y el cubo del mismo. 
        /// Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Ingresar un numero para mostrar su cuadrado y su cubo: ");
                int.TryParse(Console.ReadLine(), out numero);

                if(numero<0)
                {
                    Console.WriteLine("ERROR.¡Reingresar número!");
                }
            } while (numero<=0);

            Console.WriteLine($"\n{numero}^2: {Math.Pow(numero,2)}\n{numero}^3: {Math.Pow(numero,3)}");

        }
    }
}
