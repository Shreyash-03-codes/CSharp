namespace basics;

using System;

public class IfElse
{
    public static void Main(String[] args)
    {
        
        int age=19;
        bool hasId=true;

        if(age>=18 && hasId)
            Console.WriteLine("Eligible to Drive...");

        // if (age)     this will not work c# uses boolean value
        // {
        //     Console.WriteLine("This will not work in C#..");
        // }

        if (age < 18)
        {
            Console.WriteLine("Not Eligible to Vote");
        }
        else
        {
            Console.WriteLine("Eligible to Vote");
        }

        int marks=55;

        if(marks<=100 && marks > 89)
        {
            Console.WriteLine("A Grade");
        }
        else if(marks<=89 && marks > 79)
        {
            Console.WriteLine("B Grade");
        }
        else if(marks<=79 && marks > 69)
        {
            Console.WriteLine("C Grade");
        }
        else if(marks<=69 && marks > 59)
        {
            Console.WriteLine("D Grade");
        }
        else if(marks<=59 && marks > 49)
        {
            Console.WriteLine("E Grade");
        }
        else
        {
            Console.WriteLine("Fail");
        }


        int a=10;
        int b=90;
        int c=15;

        if(a>c)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        else
        {
            if (c > b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);                
            }
        }
    }
}