using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_ConversorBinario
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder sb = new StringBuilder();

            do
            {
                if(numeroEntero%2==0)
                {
                    sb.Insert(0, "0");
                }
                else
                {
                    sb.Insert(0, "1");
                }
                numeroEntero = numeroEntero / 2;
            } while (numeroEntero!=0);
            return sb.ToString();
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string binarioString = numeroEntero.ToString();
            int digito;
            int exponencial = binarioString.Length;
            int acumulador = 0;

            foreach (char item in binarioString)
            {
                int.TryParse(item.ToString(), out digito);
                acumulador+=(int)Math.Pow((digito*2),exponencial-1);
                exponencial--;
            }
            return acumulador;
        }
    }
}
