using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase8
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre):base(nombre)
        {

        }

        public DirectorTecnico(string nombre,DateTime fechaDeNacimiento):this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            return sb.ToString(); 
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Dni == dt2.Dni && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
