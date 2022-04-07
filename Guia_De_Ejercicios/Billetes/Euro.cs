namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 1.09F;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            Euro.cotzRespectoDolar = cotizacion;
        }

        public static void SetCotizacion(double valor)
        {
            Euro.cotzRespectoDolar = valor;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso(((Dolar)e).GetCantidad() * Peso.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == p.GetCantidad();
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
    }
}
