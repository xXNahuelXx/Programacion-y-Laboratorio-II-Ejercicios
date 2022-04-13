﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase8
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }

        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
