using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase13
{
    public class CartucheraMultiUso
    {
        public List<IAcciones> acciones;

        public CartucheraMultiUso()
        {
            this.acciones = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            bool retorno = false;
            foreach (IAcciones item in acciones)
            {
                if (((IAcciones)item).UnidadesDeEscritura>1)
                {
                    ((IAcciones)item).Escribir("Algo");
                    retorno = true;
                }
                else
                {
                    ((IAcciones)item).Recargar(20);
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
