using System;
using System.Collections.Generic;



namespace ImplementaciondePilas_ColasyListas
{
    internal class LinkedList
    {
        class Program
        {
            static void Main()
            {
                LinkedList<int> lista = new LinkedList<int>();

                
                lista.AddLast(10); 
                lista.AddLast(20); 
                lista.AddLast(30);

                
                lista.AddFirst(5);

                
                Console.WriteLine("Elementos en la lista enlazada:");
                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }

                
                lista.RemoveFirst();
                Console.WriteLine("Después de eliminar el primer elemento:");

                
                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }

                
                lista.RemoveLast();
                Console.WriteLine("Después de eliminar el último elemento:");

                
                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
