namespace Ejercicio4_LaCalculadora
{
    public class Calculadora
    {
        public static int Calcular(int numero1,int numero2,char operacion)
        {
            switch(operacion)
            {
                case '+':
                    return numero1 + numero2;
                case '-':
                    return numero1 - numero2;
                case '*':
                    return numero1 * numero2;
                case '/':
                    if (Validar(numero2))
                    {
                        return numero1 / numero2;
                    }
                    else
                    {
                        return 0;
                    }                
                default:
                    return 0;
            }
        }

        private static bool Validar(int numero2)
        {
            return numero2 != 0;
        }
    }
}
