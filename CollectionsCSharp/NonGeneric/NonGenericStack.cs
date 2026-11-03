namespace CollectionsCSharp.NonGeneric;

using System;
using System.Collections;

public class NonGenericStack
{
    public static void Main(String[] args)
    {
        Stack stack=new Stack();

        stack.Push(1);
        stack.Push('A');
        stack.Push(46);
        stack.Push("Shreyash");
        stack.Push("CSE");
        foreach(object o in stack)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        Console.WriteLine(stack.Count);
        Console.WriteLine(stack.Contains("Shreyash"));
        Console.WriteLine(stack.Peek());

        Stack copy=(Stack)stack.Clone();
        stack.Clear();
        foreach(object o in stack)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();

        foreach(object o in copy)
        {
            Console.Write(o+" ");
        }
        Console.WriteLine();        

        object?[]arr=copy.ToArray();

        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
    }
}