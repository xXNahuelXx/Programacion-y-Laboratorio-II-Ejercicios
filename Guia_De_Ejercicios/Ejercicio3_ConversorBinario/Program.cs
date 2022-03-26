using System;

namespace Ejercicio3_ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero para convertirlo a binario: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine(Conversor.ConvertirDecimalABinario(numero));

            Console.Write("Ingrese un numero binario para convertirlo a decimal: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(numero));
        }
    }
}
