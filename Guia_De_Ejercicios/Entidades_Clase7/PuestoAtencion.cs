using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades_Clase7
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2,
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public static int NumeroActual
        {
            get 
            {
                return ++PuestoAtencion.numeroActual; 
            }

        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(5000);
            return true;
        }

    }
}
