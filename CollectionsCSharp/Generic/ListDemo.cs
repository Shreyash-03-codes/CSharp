namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class ListDemo
{
    public static void Main(String[] args)
    {
        
        List<int> list=new List<int>();

        //list.Add("shreyash"); // we cannot add this because list integer type
        list.Add(32);
        list.Add(23);
        list.Add(35);
        list.Add(56);
        list.Add(45);

        foreach(int e in list)
        {
            Console.WriteLine(e);
        }

        list.Insert(1,22);
        
        Console.WriteLine();

        foreach(int e in list)
        {
            Console.WriteLine(e);
        }

        list.Remove(22);

        list.RemoveAt(2);
        Console.WriteLine();

        foreach(int e in list)
        {
            Console.WriteLine(e);
        }

        List<int> ls=list.ToList();

        ls.Add(12);

        Console.WriteLine();

        foreach(int e in list)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine();

        foreach(int e in ls)
        {
            Console.WriteLine(e);
        }

        int count=ls.Count;
        Console.WriteLine(count);
        Console.WriteLine(ls.Sum());
        Console.WriteLine(ls.Average());
        Console.WriteLine(ls.Contains(23));
    }
}