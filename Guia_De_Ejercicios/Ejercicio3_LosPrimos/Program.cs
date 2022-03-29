using System;

namespace Ejercicio3_LosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int limitador; ;
            char siOno;
            int numero = 2;

            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n1.Ingresar un numero y mostrar los numeros primos hasta el numero ingresado");
                Console.WriteLine("2.Salir");
                Console.Write("Ingrese una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:

                        Console.Clear();

                        do
                        {
                            Console.Write("Ingrese un numero: ");
                            while (!int.TryParse(Console.ReadLine(), out limitador) || limitador < 2)
                            {
                                Console.WriteLine("ERROR.\nReingrese un numero correcto!");

                            }

                            Console.WriteLine("LISTA DE NUMEROS PRIMOS");

                            while (numero <= limitador)
                            {
                                int divisible = 0;
                                for (int i = 1; i <= numero; i++)
                                {
                                    if (numero % i == 0)
                                    {
                                        divisible++;
                                    }
                                    if (divisible > 2)
                                    {
                                        break;
                                    }
                                }
                                if (divisible == 2)
                                {
                                    Console.WriteLine($"{numero}");
                                }
                                numero++;
                            }

                            numero = 0;

                            Console.Write("Desea volver a operar? s/n: ");
                            char.TryParse(Console.ReadLine(), out siOno);

                            if (siOno != 's')
                            {
                                opcion = 2;
                            }

                        } while (siOno != 'n');
                        break;
                }
            } while (opcion != 2);
        }
    }
}
