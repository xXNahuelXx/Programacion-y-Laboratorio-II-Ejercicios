using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase13
{
    public class GestionDeImpuestos 
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionDeImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal acum = 0;
            foreach(IAduana impuesto in impuestosAduana)
            {
                acum += impuesto.Impuestos;
            }
            return acum;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal acum = 0;
            foreach (IAfip impuesto in impuestosAfip)
            {
                acum += impuesto.Impuestos;
            }
            return acum; ;
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if(paquete is IAfip)
            {
                this.impuestosAfip.Add((IAfip)paquete);
            }
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach(Paquete paquetito in paquetes)
            {
                RegistrarImpuestos(paquetito);
            }
        }
    }
}
