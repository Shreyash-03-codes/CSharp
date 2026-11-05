namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class QueueDemo
{
    public static void Main(String[] args)
    {
        Queue<int> queue=new Queue<int>();

        queue.Enqueue(12);
        queue.Enqueue(34);
        queue.Enqueue(67);
        queue.Enqueue(27);
        queue.Enqueue(92);
        queue.Enqueue(1);

        foreach(int e in queue)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine();

        Console.WriteLine(queue.Count);
        Console.WriteLine(queue.Sum());
        Console.WriteLine(queue.Average());
        Console.WriteLine(queue.Peek());
        Console.WriteLine(queue.Dequeue());

        Console.WriteLine();


        
        foreach(int e in queue)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine();
    }
}