namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class PriorityQueueDemo
{
    public static void Main(String[] args)
    {
        PriorityQueue<int,int> minPq=new PriorityQueue<int,int>();

        minPq.Enqueue(12,12);
        minPq.Enqueue(11,11);
        minPq.Enqueue(10,10);
        minPq.Enqueue(9,9);
        minPq.Enqueue(8,8);

        while(minPq.Count>0)
        {
            Console.WriteLine(minPq.Dequeue());
        }

        PriorityQueue<int,int> maxPq=new PriorityQueue<int, int>(Comparer<int>.Create((a, b) =>
        {
            return b.CompareTo(a);
        }));

        maxPq.Enqueue(12,12);
        maxPq.Enqueue(10,10);
        maxPq.Enqueue(9,9);
        maxPq.Enqueue(8,8);
        maxPq.Enqueue(11,11);
        maxPq.Enqueue(13,13);

        Console.WriteLine();
        
        Console.WriteLine(maxPq.Peek());
        maxPq.Remove(13,out int e, out int p);
        Console.WriteLine(e);
        
        Console.WriteLine();

        while(maxPq.Count>0)
        {
            Console.WriteLine(maxPq.Dequeue());
        }
        
    }
}