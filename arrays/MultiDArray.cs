namespace Arrays;

using System;

public class MultiDArray
{
    public static void Main(String[] args)
    {
        int[][]nums=new int[5][];  // declaraing multi dimensional array

        nums[0]=new int[2]; // allocating space to internal array
        nums[1]=new int[5];
        nums[2]=new int[4];
        nums[3]=new int[3];
        nums[4]=new int[5];

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums[i].Length; j++)
            {
                Console.Write(nums[i][j]);   // accessing multidimensional array
            }
            Console.WriteLine();
        }

        foreach(int[]arr in nums)  // iterating the multi D array by using the foreach array
        {
            foreach(int e in arr)
            {
                Console.Write(e+2);
            }
            Console.WriteLine();
        }
        
    }
}