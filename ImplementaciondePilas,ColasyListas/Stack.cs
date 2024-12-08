using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        
        pila.Push(10); 
        pila.Push(20);
        pila.Push(30);

        Console.WriteLine($"Elemento superior: {pila.Peek()}"); 

        pila.Pop(); 
        Console.WriteLine($"Elemento superior después del Pop: {pila.Peek()}");

        
        Console.WriteLine("Elementos en la pila:");
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }
    }
}


