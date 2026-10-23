namespace Methods;

using System;

public class NamedParameters
{

    public static void Show(String name, char div, int age,int rollNo)
    {
        Console.WriteLine("the name is "+name+" the age is "+age+" the division is "+div+" the roll number is "+rollNo);
    }
    public static void Main(String[] args)
    {
        Show(age:21,rollNo:46,div:'A',name:"Shreyash Gurav");
        Show(rollNo:101,div:'B',name:"batman",age:24);
    }
}