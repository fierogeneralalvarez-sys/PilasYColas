using System;
using System.Collections.Generic;

namespace Pilas_y_colas
{
    public class ClasePila
    {
        public void Ejecutar()
        {
            Console.WriteLine("--- TRABAJANDO CON LA PILA ---");
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
            Console.WriteLine($"Elemento eliminado: {eliminado}");
            Console.WriteLine("------------------------------\n");
        }
    }
}