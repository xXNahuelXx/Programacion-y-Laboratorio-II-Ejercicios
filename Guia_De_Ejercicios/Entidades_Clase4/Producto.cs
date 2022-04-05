using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase4
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio; 

        public Producto(string marca,string codigo,float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio().ToString()}");
            sb.AppendLine($"Codigo de Barras: {(string)p}");
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p,string marca)
        {
            return p.GetMarca() == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
            //return p1.GetMarca() == p2.GetMarca() && (string)p1 == (string)p2;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
