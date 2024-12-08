using System;
using System.Collections.Generic;

namespace ImplementaciondePilas_ColasyListas
{
    internal class Queue
    {
        class Program
        {
            static void Main()
            {
                Queue<int> cola = new Queue<int>();

                
                cola.Enqueue(cola.Enqueue(10); 
                cola.Enqueue(20);
                cola.Enqueue(30);

                Console.WriteLine($"Elemento al frente: {cola.Peek()}"); 

                cola.Dequeue(); 
                Console.WriteLine($"Elemento al frente después del Dequeue: {cola.Peek()}");

                
                Console.WriteLine("Elementos en la cola:");
                foreach (var item in cola)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
