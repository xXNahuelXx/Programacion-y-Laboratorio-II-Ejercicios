﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase9
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();
    }
}
