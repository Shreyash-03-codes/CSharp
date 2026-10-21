namespace methods;

using System;

public class MaxOfThree
{
    public static void Main(String[] args)
    {
        Console.WriteLine(MaxOfThreeNumbers(1,2,3));
        Console.WriteLine(MaxOfThreeNumbers(11,20,3));
        Console.WriteLine(MaxOfThreeNumbers(41,22,93));
        Console.WriteLine(MaxOfThreeNumbers(41.0,22.23,93.99));
        Console.WriteLine(MaxOfThreeNumbers(-1,0,0));
        Console.WriteLine(MaxOfThreeNumbers(0.0,0.0,93));
        
    }

    public static int MaxOfThreeNumbers(int a,int b,int c)
    {

        Console.WriteLine("Integer Method");
        if(a>b && a > c)
        {
            return a;
        }   
        else if(b>a && b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }

    public static double MaxOfThreeNumbers(double a,double b,double c)
    {
        Console.WriteLine("Double Method");
        if(a>b && a > c)
        {
            return a;
        }   
        else if(b>a && b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}