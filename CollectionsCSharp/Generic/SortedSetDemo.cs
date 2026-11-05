namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class SortedSetDemo
{
    public static void Main(String[] args)
    {
        SortedSet<int> set=new SortedSet<int>();

        set.Add(23);
        set.Add(56);
        set.Add(22);
        set.Add(2);
        set.Add(-1);
        set.Add(0);
        set.Add(100);
        set.Add(3);

        foreach(int e in set)
        {
            Console.Write(e+" ");
        }
        Console.WriteLine();

        Console.WriteLine(set.Count);
        Console.WriteLine(set.Sum());
        Console.WriteLine(set.Max);
        Console.WriteLine(set.Max());
        Console.WriteLine(set.Min);
        Console.WriteLine(set.Min());
        Console.WriteLine(set.Average());
        set.Remove(2);

        set.Add(-1);
         foreach(int e in set)
        {
            Console.Write(e+" ");
        }
        Console.WriteLine();

        var max=set.FirstOrDefault(s=>s>22);
        var min=set.LastOrDefault(s=>s<22);

        if (max != default)
        {
            Console.WriteLine(max);
        }

        if (min != default)
        {
            Console.WriteLine(min);
        }
    }
}