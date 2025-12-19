using System;
using System.Collections.Generic;

namespace EstructurasConClases
{
    public class OperacionesPila
    {
        public void Ejecutar()
        {
            Console.WriteLine("--- INICIO DE OPERACIONES CON PILA ---");

            Stack<int> pila = new Stack<int>();
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            Console.WriteLine("Elementos en la pila:");
            foreach (var elemento in pila)
            {
                Console.WriteLine(elemento);
            }
            int eliminado = pila.Pop();
            Console.WriteLine($"Elemento eliminado (Pop): {eliminado}");

            Console.WriteLine("--------------------------------------\n");
        }
    }
    public class OperacionesCola
    {
        public void Ejecutar()
        {
            Console.WriteLine("--- INICIO DE OPERACIONES CON COLA ---");

            Queue<string> cola = new Queue<string>();
            cola.Enqueue("Uno");
            cola.Enqueue("Dos");
            cola.Enqueue("Tres");
            Console.WriteLine("Elementos en la cola:");
            foreach (var elemento in cola)
            {
                Console.WriteLine(elemento);
            }
            string eliminado = cola.Dequeue();
            Console.WriteLine($"Elemento eliminado (Dequeue): {eliminado}");

            Console.WriteLine("--------------------------------------\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesPila miPila = new OperacionesPila();
            miPila.Ejecutar();

            OperacionesCola miCola = new OperacionesCola();
            miCola.Ejecutar();
            Console.ReadKey();
        }
    }
}