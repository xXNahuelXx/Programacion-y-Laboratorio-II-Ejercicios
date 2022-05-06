using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase11
{
    public static class Calculadora
    {
        public static int Add(string numeros)
        {
            if(!string.IsNullOrEmpty(numeros))
            {
                
                if(numeros[0]=='/' && numeros[1]=='/')
                {
                    char delimitador = numeros[2];
                    numeros = numeros.Substring(2).Replace(delimitador,',');
                }
                string[] num = numeros.Split(new char[] { ',','\n'},StringSplitOptions.RemoveEmptyEntries);
                int acum = 0;

                for (int i = 0; i < num.Length; i++)
                {
                    if(int.Parse(num[i]) < 0)
                    {
                        throw new NegativoNoPermitidoException($"No se pueden numeros negativos: {num[i]}");
                    }
                    else
                    {
                        acum += int.Parse(num[i]);
                    }
                }
                return acum;
            }
            else
            {
                return 0;
            }
        }
    }
}
