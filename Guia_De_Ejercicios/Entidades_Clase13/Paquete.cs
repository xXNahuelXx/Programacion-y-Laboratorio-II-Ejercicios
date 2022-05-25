using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase13
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get;}

        public decimal Impuestos
        {
            get
            {
                return (this.costoEnvio*35)/100;
            }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Seguimiento : {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de Envio: ${this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso: {this.pesoKg}Kg");
            if(this.TienePrioridad is true)
            {
                sb.AppendLine($"Tiene prioridad");
            }
            else
            {
                sb.AppendLine($"No tiene prioridad");
            }
            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio+this.Impuestos;
        }
    }
}
