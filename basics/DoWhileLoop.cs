namespace basics;

using System;

public class DoWhileLoop
{
    public static void Main(String[] args)
    {
        
        int num=10;

        // do       // do while loop is exit control loop which will iterate atleast once
        // {
        //     Console.WriteLine("i will always execute atleast once..");
        // }while(num<9);

        do
        {
            Console.WriteLine(num--);
        }
        while(num>0);

    }
}