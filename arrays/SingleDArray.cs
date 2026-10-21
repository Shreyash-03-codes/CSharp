namespace arrays;

using System;

public class SingleDArray
{
    public static void Main(String[] args)
    {
        int[]arr={1,2,3,4,5}; // declaration and initialization of array at a time

        int[]nums=new int[6];  // declaration
        nums[0]=1; // assigning values
        nums[1]=2;
        nums[2]=33;
        nums[3]=3;
        nums[4]=4;
        nums[5]=5;

        Console.WriteLine(nums[2]);  // accessing an element from array


        Console.WriteLine(new int[]{1,2,3,4,5}.Min()); // this is anonymous array

        for(int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }

        Console.WriteLine(nums.GetType());  // we can get the type of array


        Console.WriteLine(nums[^6]);  // ^ this is used access element by using right side indexing

        int[]n=nums[0..3];   // slices the array

        Console.WriteLine(n[0]+" "+n[1]+" "+n[2]);


        foreach(int e in nums)
        {
            Console.WriteLine(e*5);
        }
        

    }
}