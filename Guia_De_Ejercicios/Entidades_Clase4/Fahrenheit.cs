using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class Fahrenheit
    {
        private double valor;

        public Fahrenheit(double valor)
        {
            this.valor = valor;
        }

        public double GetValorFahrenheit()
        {
            return this.valor;
        }

        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c.GetValorCelsius() * (9 / 5)) + 32);
        }

        public static implicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetValorKelvin()*(9/5))-459.67f);
        }
    }
}
