namespace Basics;

using System;

public class SwitchCase
{
    public static void Main(String[] args)
    {
        int day=6;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Weekend");
                break;
            default: 
                Console.WriteLine("Invalid day");
                break;
        }

        int age=19;

        string result= age switch
        {
            > 18 => "Can Drive",
            _=> "Cant Drive"
        };

        Console.WriteLine(result);

        Object num=10;

        string describe = num switch
        {
            int i=>"Integer",
            string s=> "String",
            long l => "long",
            char c=>"char",
            _=>"Invalid type"
        };

        Console.WriteLine(describe);
    }
}