using System;
using Entidades_Clase10;

namespace Ejercicio1_LanzaryAtrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase objeto = new OtraClase();
                objeto.OtroMetodo();
            }
            catch (MiExcepcion ex)
            {
                //Mensaje de MiExcepcion
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
