using System;

namespace Ejercicio4_LaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1=0;
            int numero2=0;
            char operador;
            int opcion;

            do
            {
                Console.WriteLine("MENU CALCULADORA");
                Console.WriteLine("1) Ingrese primer numero");
                Console.WriteLine("2) Ingrese segundo numero");
                Console.WriteLine("3) Ingrese el operador para realizar la operacion con los numeros ingresados: (+ - * /)");
                Console.WriteLine("4) Salir");
                Console.Write("Ingrese una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        int.TryParse(Console.ReadLine(), out numero1);
                        break;
                    case 2:
                        int.TryParse(Console.ReadLine(), out numero2);
                        break;
                    case 3:
                        char.TryParse(Console.ReadLine(), out operador);
                        Console.WriteLine($"{numero1} {operador} {numero2} = {Calculadora.Calcular(numero1,numero2,operador)}");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
