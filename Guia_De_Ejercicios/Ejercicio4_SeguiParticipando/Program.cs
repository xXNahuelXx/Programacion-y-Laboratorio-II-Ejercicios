﻿using Entidades_Clase10;
using System;

namespace Ejercicio4_SeguiParticipando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia f1 = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            Competencia motocross = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(4, "Red Bull Racing", 2);
            AutoF1 a2 = new AutoF1(5, "Ferrari", 45);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);
            MotoCross m2 = new MotoCross(9, "Mc Laren", 32);
            VehiculoDeCarrera v = new VehiculoDeCarrera(6, "Mercedes Benz");

            try
            {
                if (f1 + a1)
                {
                    Console.WriteLine($"Agregue A1 a competencia F1: \n{a1.MostrarDatos()}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



            try
            {
                if (f1 + a2)
                {
                    Console.WriteLine($"Agregue A2 a competencia F1: \n{a2.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            try
            {
                if (f1 + m1)
                {
                    Console.WriteLine($"Agregue M1 a competencia F1: \n{m1.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            try
            {
                if (motocross + m1)
                {
                    Console.WriteLine($"Agregue M1 a competencia MotoCross: \n{m1.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            try
            {
                if (motocross + m2)
                {
                    Console.WriteLine($"Agregue M2 a competencia MotoCross: \n{m1.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            try
            {
                if (motocross + a2)
                {
                    Console.WriteLine($"Agregue A2 a competencia MotoCross: \n{m1.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            try
            {
                if (f1 + v)
                {
                    Console.WriteLine($"Agregue VEHICULO a competencia F1: \n{a1.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



            Console.WriteLine($"-------------------------------------\nCOMPETENCIA F1: \n{f1.MostrarDatos()}\n");
            Console.WriteLine($"-------------------------------------\nCOMPETENCIA MotoCross: \n{motocross.MostrarDatos()}\n");
        }
    }
}
