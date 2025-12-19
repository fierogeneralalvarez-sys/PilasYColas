using System;
using System.Collections.Generic;

namespace Pilas_y_colas
{
    public class ClaseCola
    {
        public void Ejecutar()
        {
            Console.WriteLine("--- TRABAJANDO CON LA COLA ---");
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
            Console.WriteLine($"Elemento eliminado: {eliminado}");
            Console.WriteLine("------------------------------\n");
        }
    }
}