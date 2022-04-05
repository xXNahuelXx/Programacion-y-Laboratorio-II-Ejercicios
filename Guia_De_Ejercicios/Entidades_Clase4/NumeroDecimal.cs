using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero()
        {
            return this.numero;
        }

        public static double operator +(NumeroDecimal numeroDecimal,NumeroBinario numeroBinario)
        {
           return numeroDecimal.GetNumero() + ((NumeroDecimal)numeroBinario).GetNumero();
        }

        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
           return numeroDecimal.GetNumero() - ((NumeroDecimal)numeroBinario).GetNumero();
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.GetNumero() == ((NumeroDecimal)numeroBinario).GetNumero();
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }

        public static explicit operator double(NumeroDecimal objDecimal)
        {
            return objDecimal.numero;
        }

        public static implicit operator NumeroDecimal(double numeroBinario)
        {
            return new NumeroDecimal(numeroBinario);
        }

        public static explicit operator NumeroBinario(NumeroDecimal objDecimal)
        {
            return (NumeroBinario)Conversor.ConvertirDecimalABinario(objDecimal.numero);
        }
    }
}
