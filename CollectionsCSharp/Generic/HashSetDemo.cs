namespace CollectionsCSharp.Generic;

using System;
using System.Collections;
using System.Collections.Generic;

public class SetDemo
{
    public static void Main(String[] args)
    {
        HashSet<string> set=new HashSet<string>();

        set.Add("Shreyash");
        set.Add("shreyash");

        Console.WriteLine(set.Count);

        set.Add("gurav");

        foreach(string str in set)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine(set.Contains("gurav"));

        IEnumerable<string> s=set.Distinct();

        foreach(string str in s)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();


        ISet<string> setCopy=set.ToHashSet();
        foreach(string str in setCopy)
        {
            Console.WriteLine(str);
        }


    }
}