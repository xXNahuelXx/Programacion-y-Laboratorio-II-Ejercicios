using System;
using System.Text;

namespace EntidadesClase3
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.nombre = value;
            }
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }


        public string GetDni()
        {
            return this.dni;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            int edad = DateTime.Today.AddTicks(-this.fechaDeNacimiento.Ticks).Year - 1;
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaDeNacimiento()}");
            sb.AppendLine($"Dni: {GetDni()}");
            sb.AppendLine($"Edad: {CalcularEdad()}");
            sb.AppendLine($"{EsMayorDeEdad()}");
            return sb.ToString();
        }
        
        public string EsMayorDeEdad()
        {
            if(CalcularEdad()>18)
            {
                return "Es mayor edad";
            }
            return "Es menor";
        }
    }
}
