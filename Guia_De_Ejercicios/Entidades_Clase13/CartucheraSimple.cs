using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase13
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public CartucheraSimple()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }

        public bool RecorrerElementos()
        {
            bool retorno = false;
            foreach (Boligrafo boligrafo in boligrafos)
            {
                if (boligrafo.UnidadesDeEscritura > 1)
                {
                    boligrafo.Escribir("Algo");
                    retorno = true;
                }
                else
                {
                    boligrafo.Recargar(20);
                    retorno = false;
                }
            }
            foreach (Lapiz lapiz in lapices)
            {
                if (((IAcciones)lapiz).UnidadesDeEscritura > 1)
                {
                    ((IAcciones)lapiz).Escribir("Algo");
                    retorno = true;
                }
                else
                {
                    ((IAcciones)lapiz).Recargar(20);
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
