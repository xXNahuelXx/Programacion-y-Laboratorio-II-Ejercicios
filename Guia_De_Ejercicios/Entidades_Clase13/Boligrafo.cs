using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase13
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura 
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            foreach (char c in texto)
            {
               this.UnidadesDeEscritura -= 0.3f;
            }
            return new EscrituraWrapper(texto,this.Color);
        }

        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            return $"Soy boligrafo\nNivel de Tinta: {this.UnidadesDeEscritura}\nColor: {this.Color}";
        }
    }
}
