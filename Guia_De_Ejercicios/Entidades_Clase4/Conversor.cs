using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder sb = new StringBuilder();

            do
            {
                if (numeroEntero % 2 == 0)
                {
                    sb.Insert(0, "0");
                }
                else
                {
                    sb.Insert(0, "1");
                }
                numeroEntero = numeroEntero / 2;
            } while (numeroEntero != 0);
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
                acumulador += (int)Math.Pow((digito * 2), exponencial - 1);
                exponencial--;
            }
            return acumulador;
        }

        public static int ConvertirBinarioADecimal(string binarioString)
        {
            int digito;
            int exponencial = binarioString.Length;
            int acumulador = 0;

            foreach (char item in binarioString)
            {
                int.TryParse(item.ToString(), out digito);
                acumulador += (int)Math.Pow((digito * 2), exponencial - 1);
                exponencial--;
            }
            return acumulador;
        }

        public static string ConvertirDecimalABinario(double numeroDouble)
        {
            StringBuilder sb = new StringBuilder();
            int algo=(int) numeroDouble;
            do
            {
                if (algo % 2 == 0)
                {
                    sb.Insert(0, "0");
                }
                else
                {
                    sb.Insert(0, "1");
                }
                algo = algo / 2;
            } while (algo != 0);
            return sb.ToString();
        }
    }
}
