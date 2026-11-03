namespace CollectionsCSharp.NonGeneric;

using System;
using System.Collections;

public class NonGenericSortedList
{
    public static void Main(String[] args)
    {
        SortedList sl=new SortedList();

        sl.Add("Shreyash","Gurav");
        sl.Add("A","SBG");
        sl.Add("0","Shreyash");
        sl.Add("a","gurav");
        sl.Add("b","Batman");
        sl.Add("C","catwomen");
        sl.Add("aaa","aaaaa");
        sl.Add("AA","Batman");

        foreach(object o in sl)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();


        Console.WriteLine(sl["A"]);
        Console.WriteLine(sl.Count);
        Console.WriteLine(sl.ContainsValue("Shreyash"));
        Console.WriteLine(sl.ContainsKey("46"));
        Console.WriteLine(sl.ContainsKey("aaa"));

        sl["aaa"]="aaaaaaaaaaaaaaaaaa";
        Console.WriteLine(sl["aaa"]);

        SortedList slCopy=(SortedList)sl.Clone();
        sl.Clear();
        foreach(object o in slCopy)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();
        foreach(object o in sl)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();
    }
}