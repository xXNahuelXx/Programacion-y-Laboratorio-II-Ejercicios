using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase13
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura 
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach(char c in texto)
            {
                ((IAcciones)this).UnidadesDeEscritura -= 0.1f;
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Soy Lapiz\nNivel de Tinta: {((IAcciones)this).UnidadesDeEscritura}\nColor: {((IAcciones)this).Color}";
        }
    }
}
