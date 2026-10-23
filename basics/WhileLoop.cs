namespace Basics;

using System;

public class WhileLoop
{
    public static void Main(String[] args)
    {
        
        int num=100;

        while (num > 0)   // here boolean value is mandatory if true then iteration will be executed otherewise loop will exit
        {
            Console.Write((num--)+" ");
        }

    }
}