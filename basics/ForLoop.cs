namespace Basics;

using System;

public class ForLoop
{
    public static void Main(String[] args)
    {
        // int i=1;

        // for(
        //     Console.WriteLine("Entering to for loop"); // initilization statement which will execute only once at the starting time
        //     i<=10; // it should return boolean value, if true iteration will execute otherwise for loop will execute
        //     Console.WriteLine(i-1+"th iteration") // this statement will always executes after iteration
        // )
        // {
        //     i++;
        // }

        // Console.WriteLine("End of for loop..");

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}