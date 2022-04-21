using System.Collections.Generic;

namespace Entidades_Clase7
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < this.paginas.Count)
                {
                    return this.paginas[index];
                }
                return "Página no valida";
            }

            set
            {
                if(index > paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else
                {
                    this.paginas.Insert(index,value);
                }
            }
        }
    }
}
