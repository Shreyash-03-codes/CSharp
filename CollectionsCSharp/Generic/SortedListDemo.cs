namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class SortedListDemo
{
    public static void Main(string[] args)
    {
        SortedList<int,int> list=new SortedList<int,int>();

        list.Add(1,23);
        list.Add(12,21);
        list.Add(23,32);                 
        list.Add(45,54);
        list.Add(35,65);

        Console.WriteLine(list[12]);
        // Console.WriteLine(list[2]);       this line thorws error because keys does not exists
        Console.WriteLine(list.Contains(KeyValuePair.Create(12,21)));
        Console.WriteLine(list.Count);

        foreach(KeyValuePair<int,int> kv in list)
        {
            Console.WriteLine(kv.Key+" "+kv.Value);
        }
        Console.WriteLine();

        list.Remove(12);

        foreach(KeyValuePair<int,int> kv in list)
        {
            Console.WriteLine(kv.Key+" "+kv.Value);
        }
        Console.WriteLine();

        
        
    }
}

