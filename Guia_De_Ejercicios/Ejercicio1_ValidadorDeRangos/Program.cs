using System;
using Validaciones;

namespace Ejercicio1_ValidadorDeRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            int flag=0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                if(Validador.Validar(numero,-100,100))
                {
                    if(numero>maximo || i==0)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo || i == 0)
                    {
                        minimo = numero;
                    }
                    acumulador += numero;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("ERROR. Numero fuera de rango!");
            }
            else
            {
                promedio = (float)acumulador / 10;
                Console.WriteLine($"El valor maximo es: {maximo}\nEl valor minimo es: {minimo}\nEl promedio es: {promedio}");
            }
            
        }
    }
}
