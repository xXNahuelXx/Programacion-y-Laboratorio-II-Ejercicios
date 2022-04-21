using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_SobrescribiendoEsasAdvertencias
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiAtributo { get; }

        public override string ToString()
        {
            return "¡Este es mi método ToString Sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            //obj is Sobrescrito; Para chequear que algo sea de un tipo especifico.
            //obj.GetType() == this.GetType(); Devuelve el tipo real en memoria. 
            //Sobrescrito aux = obj as Sobrescrito; Si el objeto es de tipo Sobrescrito lo guarda en la variable sino, guarda null.
            return obj.GetType() == typeof(Sobrescrito); //Para chequear que algo sea de un tipo especifico.
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

        public abstract string MiMetodo();
    }
}
