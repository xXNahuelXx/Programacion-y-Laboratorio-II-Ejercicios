using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase3
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(this.tinta<100 && tinta>0)
            {
                this.tinta+=tinta;
            }
        }
    }
}
