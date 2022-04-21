using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_SobrescribiendoEsasAdvertencias
{
    public class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito():base()
        {

        }

        public override string MiAtributo
        {
            get
            {
                return base.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiAtributo;
        }
    }
}
