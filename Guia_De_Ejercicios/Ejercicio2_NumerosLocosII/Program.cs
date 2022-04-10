using System;
using System.Collections.Generic;

namespace Ejercicio2_NumerosLocosII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            Stack<int> pilaPositivos = new Stack<int>();
            Stack<int> pilaNegativos = new Stack<int>();
            Queue<int> colaPositivos = new Queue<int>();           
            Queue<int> colaNegativos = new Queue<int>();
            Random random = new Random();

            #region Lista
            for (int i=0;i<20;i++)
            {
                listaNumeros.Add(random.Next(-100, 100));
            }
            Console.WriteLine("\nINGRESADO LIST");
            Program.MostrarLista(listaNumeros);
            Console.WriteLine("\nORDENADO");
            listaNumeros.Sort(OrdenDescendente);
            Program.MostrarLista(listaNumeros);
            #endregion

            Console.WriteLine("Lista Positivos");
            foreach (int i in listaNumeros)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    colaPositivos.Enqueue(i);
                }
                else if (i != 0)
                {
                    pilaNegativos.Push(i);
                }
            }

            Console.WriteLine("Lista Negativos");
            for (int i = listaNumeros.Count - 1; i >= 0; i--)
            {
                if (listaNumeros[i] > 0)
                {
                    pilaPositivos.Push(listaNumeros[i]);//agrego positivo a la pila de positivos
                }
                else if (i != 0)//evito el cero
                {
                    Console.WriteLine(listaNumeros[i]);
                    colaNegativos.Enqueue(listaNumeros[i]);//agrego negativos a la lista de negativos
                }
            }

            Console.WriteLine(" Cola Positivos");
            foreach (int i in colaPositivos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Positivos");
            foreach (int i in pilaPositivos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Cola Negativos");
            foreach (int i in colaNegativos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Negativos");
            foreach (int i in pilaNegativos)
            {
                Console.WriteLine(i);
            }
        }

        public static void MostrarLista(List<int> listaNumeros)
        {
            foreach(int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void MostrarPila(Stack<int> pilaNumeros)
        {
            foreach (int item in pilaNumeros)
            {
                Console.WriteLine(item);
            }
        }

        public static int OrdenDescendente(int a,int b)
        {
            return b - a;
        }
    }
}
