using System.Collections.Generic;

namespace Entidades_Clase12
{
    public class Contabilidad<T, U> where T : Documento where U : Documento,new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.Egresos = new List<T>();
            this.Ingresos = new List<U>();
        }

        public List<T> Egresos { get => egresos; set => egresos = value; }
        public List<U> Ingresos { get => ingresos; set => ingresos = value; }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.Egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.Ingresos.Add(ingreso);
            return c;
        }
    }
}
