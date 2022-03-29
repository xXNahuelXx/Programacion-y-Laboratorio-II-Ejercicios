using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase3
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular,decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        private string GetTitular()
        {
            return this.titular;
        }

        private decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {

            return $"Titular: {GetTitular()}\nCantidad: ${GetCantidad()}";
        }


        public void Ingresar(decimal montoaAcreditar)
        {
            if (montoaAcreditar > 0)
            {
                this.cantidad += montoaAcreditar;
            }
        }

        public void Retirar(decimal montoaDebitar)
        {
            if (montoaDebitar > 0)
            {
                this.cantidad -= montoaDebitar;
            }
        }
    }
}
