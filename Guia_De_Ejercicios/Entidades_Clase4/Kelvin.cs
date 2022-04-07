using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class Kelvin
    {
        private double valor;

        public Kelvin(double valor)
        {
            this.valor = valor;
        }

        public double GetValorKelvin()
        {
            return this.valor;
        }

        public static implicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetValorFahrenheit() + 459.67f)*(5/9));
        }
    }
}
