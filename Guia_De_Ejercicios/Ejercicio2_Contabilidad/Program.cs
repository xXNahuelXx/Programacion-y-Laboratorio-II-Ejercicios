using System;
using Entidades_Clase12;

namespace Ejercicio2_Contabilidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            Factura factura = new Factura(20);
            Recibo recibo1 = new Recibo();
            Recibo recibo2 = new Recibo(24);

            contabilidad += factura;
            contabilidad += recibo1;
            contabilidad += recibo2;

            Console.WriteLine("EGRESOS");
            foreach (Factura item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero);
            }
            Console.WriteLine("INGRESOS");
            foreach (Recibo item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}
