﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase8
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(long dni,string nombre) : this(nombre)
        {
            this.dni=dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public long Dni
        {
            get
            {
                return this.dni;
            }

            set
            {
                this.dni = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"Nombre: {Nombre}");
            return sb.ToString();
        }
    }
}
