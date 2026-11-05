namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class DictionaryDemo
{
    public static void Main(String[] args)
    {
        Dictionary<int,string> map=new Dictionary<int,string>();

        map.Add(46,"Shreyash");
        map.Add(2,"Batman");
        map.Add(36,"ABC");
        map.Add(55,"Shockwave");

        Console.WriteLine(map[46]);
        // Console.WriteLine(map[1]);  // if key not present then its thorws error

        foreach(int key in map.Keys)
        {
            Console.Write(map[key]+" ");
        }
        Console.WriteLine();

        map[36]="Prime";

        foreach(int key in map.Keys)
        {
            Console.Write(map[key]+" ");
        }
        Console.WriteLine();

    }
}