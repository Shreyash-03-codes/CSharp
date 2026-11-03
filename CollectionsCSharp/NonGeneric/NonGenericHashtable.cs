namespace CollectionsCSharp.NonGeneric;

using System;
using System.Collections;

public class NonGenericHashtable
{
    public static void Main(String[] args)
    {
        Hashtable hashtable=new Hashtable();

        hashtable.Add(46,"Shreyash");
        hashtable.Add("guravshreyash@gmail.com","Shreyash Gurav");
        hashtable.Add('A',46);

        foreach(object o in hashtable)
        {
            Console.WriteLine(o);
        }

        Console.WriteLine(hashtable.ContainsKey(46));
        Console.WriteLine(hashtable.Contains(46));
        Console.WriteLine(hashtable.Count);
        Console.WriteLine();
        foreach(object o in hashtable.Keys)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();
        foreach(object o in hashtable.Values)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        Hashtable copy=(Hashtable)hashtable.Clone();

        copy[46]="Batman";

        foreach(object o in copy)
        {
            Console.WriteLine(o);
        }

        Console.WriteLine(hashtable[90]);
        Console.WriteLine(hashtable[46]);

        
    }
}