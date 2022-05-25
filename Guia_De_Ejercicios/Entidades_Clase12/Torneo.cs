using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase12
{
    public class Torneo<T> where T : Equipo 
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random indiceRandom = new Random();
                T equipo1;
                T equipo2;
                do
                {
                    equipo1 = this.equipos[indiceRandom.Next(0, equipos.Count)];
                    equipo2 = this.equipos[indiceRandom.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);
                return CalcularPartido(equipo1, equipo2);
            }
        }

        public static bool operator ==(Torneo<T> torneo,T equipo)
        {
            foreach (T e in torneo.equipos)
            {
                if(e==equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo); 
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del Torneo: {this.nombre}");
            sb.AppendLine("Equipos");
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine($"{equipo.Ficha()}");
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1,T equipo2)
        {
            Random random = new Random();
            return $"{equipo1.Nombre} - {random.Next(0, 10)} | {equipo2.Nombre} - {random.Next(0, 10)}";
        }
    }
}
