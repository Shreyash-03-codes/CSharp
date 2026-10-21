namespace methods;

using System;

public class IsEven
{
    public static void Main(String[] args)
    {
        Console.WriteLine(IsEvenNumber(3));
        Console.WriteLine(IsEvenNumber(0));
        Console.WriteLine(IsEvenNumber(1));
        Console.WriteLine(IsEvenNumber(300));
        
    }

    public static bool IsEvenNumber(int num)
    {
        return (num&1)!=1;   
    }
}