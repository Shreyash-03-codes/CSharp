namespace methods;

using System;

public class ArguementModifiers
{

    public static void GetDetails(out string name, out int age)
    {
        name="Shreyash";
        age=21;
    }

    public static void Swap(ref int num1,ref int num2)
    {
        int temp=num1;
        num1=num2;
        num2=temp;
        
    }

    public static void ShowDetails(in string name,in int age)
    {
        Console.WriteLine("The name is "+name+" the age is "+age);
        //age=age+2;  // this will thow error, we can mmodifie this because this readonly
        
    }

    public static void Main(String[] args)
    {
        GetDetails(out string name, out int age);
        Console.WriteLine("The name is "+name+" the age is "+age);

        int num1=10;
        int num2=20;
        Console.WriteLine("num1: "+num1+" num2: "+num2);
        Swap(ref num1,ref num2);
        Console.WriteLine("num1: "+num1+" num2: "+num2);

        ShowDetails(in name,in age);
    }
}