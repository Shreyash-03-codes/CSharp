namespace CollectionsCSharp.NonGeneric;

using System;
using System.Collections;

public class NonGenericQueue
{
    public static void Main(String[] args)
    {
        
        Queue queue=new Queue();

        queue.Enqueue(1);
        queue.Enqueue('A');
        queue.Enqueue(46);
        queue.Enqueue("Shreyash");
        queue.Enqueue("CSE");

        foreach(object o in queue)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        Console.WriteLine(queue.Count);
        object?[]arr=queue.ToArray();
        foreach(object o in queue)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        object? first=queue.Dequeue();

        Console.WriteLine(first);

         foreach(object o in queue)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        Queue copy=(Queue)queue.Clone();

        queue.Clear();

        foreach(object o in queue)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        foreach(object o in copy)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        Console.WriteLine(copy.Contains("Shreyash"));

        Console.WriteLine(copy.Peek());
    }
}