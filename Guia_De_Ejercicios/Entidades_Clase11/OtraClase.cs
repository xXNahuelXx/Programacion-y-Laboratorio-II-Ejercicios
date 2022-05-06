using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase11
{
    public class OtraClase
    {
        public void OtroMetodo()
        {
            try
            {
                new MiClase(2);
            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("Relanzo desde OtraClase", ex);
            }
        }
    }
}
