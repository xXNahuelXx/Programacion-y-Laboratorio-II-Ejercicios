﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase6
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1():this(0,string.Empty)
        {

        }
        
        private AutoF1(short cantidadCombustible, bool enCompetencia, short vueltasRestantes)
        {
            this.cantidadCombustible = cantidadCombustible;
            this.enCompetencia = enCompetencia;
            this.vueltasRestantes = vueltasRestantes;
        }

        public AutoF1(short numero, string escuderia):this(0,false,0)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public short SetCantidadCombustible
        {
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool SetEnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }
        }
        public short SetVueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Auto Numero: {this.numero}");
            sb.AppendLine($"¿Está compitiendo?: {GetEnCompetencia()}");
            sb.AppendLine($"Cantidad de Combustible: {GetCantidadCombustible()}");
            sb.AppendLine($"Vueltas restantes: {GetVueltasRestantes()}");
            return sb.ToString();
        }
    }
}
