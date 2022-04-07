using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class Celsius
    {
        private double valor;

        public Celsius(double valor)
        {
            this.valor = valor;
        }

        public double GetValorCelsius()
        {
            return this.valor;
        }

        public static implicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetValorFahrenheit()-32)*5/9);
        }
    }
}
