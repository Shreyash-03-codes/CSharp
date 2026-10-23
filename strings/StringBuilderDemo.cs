namespace Strings;

using System;
using System.Text;

public class StringBuilderDemo
{
    public static void Main(String[] args)
    {
        
        StringBuilder sb=new StringBuilder();
        Console.WriteLine(sb.Length);
        Console.WriteLine(sb.Capacity);

        sb.Append("Shreyash").Append(" ").Append("Gurav");
        Console.WriteLine(sb);
        sb.Append("\n");
        sb.Append("Fullstack Developer");
        Console.WriteLine(sb);
        Console.WriteLine(sb.GetType());
        String text=sb.ToString();
        Console.WriteLine(text);
        Console.WriteLine(text.GetType());
        sb.Insert(9,"Bhagwan");
        sb.Insert(16," ");
        Console.WriteLine(sb);
        sb.Replace("lls","ll-S");
        Console.WriteLine(sb); 
        sb.Remove(0,8);
        Console.WriteLine(sb);
        Console.WriteLine(sb.Length);
        Console.WriteLine(sb.Capacity);
    }
}