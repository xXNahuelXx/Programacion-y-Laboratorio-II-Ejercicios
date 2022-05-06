using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase11
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MiMetodo();
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException("Relanzo en primer constructor",ex);
            }
        }

        public MiClase(int num)
        {
            try
            {
                new MiClase();
            }
            catch(DivideByZeroException excepcion)
            {
                throw new UnaExcepcion("Relanzo en segundo constructor", excepcion);
            }
        }

        public static void MiMetodo()
        {
            throw new DivideByZeroException("Lanzo primera vez");
        }
    }
}
