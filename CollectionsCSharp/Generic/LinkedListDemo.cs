namespace CollectionsCSharp;

using System;
using System.Collections.Generic;

public class LinkedListDemo
{
    public static void Main(String[] args)
    {
        LinkedList<string> list=new LinkedList<string>();

        list.AddFirst("Shreyash");
        LinkedListNode<String>? node=list.Find("Shreyash");
        list.AddAfter(node!,"Bhagwan");
        list.AddLast("Gurav");
        list.AddBefore(node!,"Mr");

        foreach(string n in list)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();

        list.Remove("Mr");

        foreach(string n in list)
        {
            Console.WriteLine(n);
        }

        list.RemoveFirst();
        list.RemoveLast();
        Console.WriteLine();
        foreach(string n in list)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        
    }
}