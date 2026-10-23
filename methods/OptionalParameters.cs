namespace Methods;

using System;

public class OptionalParameters
{

    public static void Show(String name="Unknown",int age = 18)
    {
        Console.WriteLine("The name is "+name);
        Console.WriteLine("The age is "+age);
        
    }
    public static void Main(String[] args)
    {

        Show("Shreyash",21);
        Show("ABC");
        Show(age:12);
        
    }
}