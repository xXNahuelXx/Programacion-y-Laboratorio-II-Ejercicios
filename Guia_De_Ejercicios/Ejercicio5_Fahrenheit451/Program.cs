using System;
using Entidades_Clase4;

namespace Ejercicio5_Fahrenheit451
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f = new Fahrenheit(10);
            Celsius c = new Celsius(8);
            Kelvin k = new Kelvin(12);

            //Muestro la temperatura individualmente en las distintas escalas  
            Console.WriteLine($"{f.GetValorFahrenheit()}° Fahrenheit");
            Console.WriteLine($"{c.GetValorCelsius()}° Celsius");
            Console.WriteLine($"{k.GetValorKelvin()}° Kelvin");

            //Paso Celsius a Fahrenheit
            f = c;
            Console.WriteLine($"{c.GetValorCelsius()}° Celsius son {f.GetValorFahrenheit()}° Fahrenheit");

            //Paso Fahrenheit a Celsius
            c = f;
            Console.WriteLine($"{f.GetValorFahrenheit()}° Fahrenheit son {c.GetValorCelsius()}° Celsius");

            //Paso Kelvin a Fahrenheit
            f = k;
            Console.WriteLine($"{k.GetValorKelvin()}° Kelvin son {f.GetValorFahrenheit()}° Fahrenheit");

            //Paso Fahrenheit a Kelvin
            k = f;
            Console.WriteLine($"{f.GetValorFahrenheit()}° Fahrenheit son {k.GetValorKelvin()}° Kelvin");
        }
    }
}
