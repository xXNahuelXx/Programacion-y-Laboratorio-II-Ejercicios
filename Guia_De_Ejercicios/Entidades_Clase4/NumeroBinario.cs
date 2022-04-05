using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double resultado = ((NumeroDecimal)numeroBinario).GetNumero() + numeroDecimal.GetNumero();
            return Conversor.ConvertirDecimalABinario(resultado);
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double resultado = ((NumeroDecimal)numeroBinario).GetNumero() - numeroDecimal.GetNumero();
            return Conversor.ConvertirDecimalABinario(resultado);
        }

        public static explicit operator NumeroDecimal(NumeroBinario numeroDecimal)
        {
            return (NumeroDecimal)Conversor.ConvertirBinarioADecimal(numeroDecimal.numero);
        }

        public static bool operator ==(NumeroBinario numeroBinario,NumeroDecimal numeroDecimal)
        {
            //return string.Equals(numeroBinario.GetNumero(), ((NumeroBinario)numeroDecimal).GetNumero());
            return numeroBinario.GetNumero() == ((NumeroBinario)numeroDecimal).GetNumero();
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }

        public static implicit operator NumeroBinario(string numeroBinario)
        {
            return new NumeroBinario(numeroBinario);
        }
    }
}
