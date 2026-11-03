namespace CollectionsCSharp.NonGeneric;

using System;
using System.Collections;

public class ArrayListDemo
{
    public static void Main(String[] args)
    {
        ArrayList list=new ArrayList();

        list.Add(1);
        list.Add("Shreyash");
        list.Add('A');
        foreach(object o in list)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();
        list.Insert(2,"Gurav");
        object?[]arr=list.ToArray();
        foreach(object? o in arr)
        {
            Console.Write(o+" ");
        }

        Console.WriteLine();

        Console.WriteLine(list.Contains("Shreyash"));

        Console.WriteLine(list.IndexOf('A'));

        Console.WriteLine(list.Count);
        list.Remove("Shreyash");

        foreach(object o in list)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        list.RemoveAt(0);

        foreach(object o in list)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();
    }
}