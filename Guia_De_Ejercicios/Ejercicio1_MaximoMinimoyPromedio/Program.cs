using System;

namespace Ejercicio1_MaximoMinimoyPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero > maximo || i == 0)
                {
                    maximo = numero;
                }
                if (numero < minimo || i == 0)
                {
                    minimo = numero;
                }
                acumulador += numero;
            }
            promedio = (float)acumulador / 5;
            Console.WriteLine($"El valor maximo es: {maximo}\nEl valor minimo es: {minimo}\nEl promedio es: {promedio}");
        }
    }
}
