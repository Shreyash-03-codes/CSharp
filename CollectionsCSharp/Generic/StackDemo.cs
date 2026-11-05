namespace CollectionsCSharp;

using System;
using System.Collections.Generic;

public class StackDemo
{
    public static void Main(String[] args)
    {
        Stack<char> stack=new Stack<char>();

        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        
        foreach(char c in stack)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine();

        Console.WriteLine(stack.Count);
        Console.WriteLine(stack.Capacity);
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());

        Console.WriteLine();

        foreach(char c in stack)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine();
    }
}