namespace Basics;

using System;

public class Input
{
    public static void Main(String[] args)
    {

        /*
        Console.WriteLine("Enter Your Name..!");
        String? name = Console.ReadLine();
        Console.WriteLine("Enter Your Age..!!");
        int age =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The name is "+ name +" and The age is "+age);
        */


        /*
        Console.WriteLine("Enter Number 1:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2:");
        int num2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Addition of "+num1+" and "+num2+" is "+(num1+num2));
        */

        Console.WriteLine("Enter Lenght :");
        double lenght=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Side :");
        double side=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The Area is "+(lenght*side));
        
    }
}