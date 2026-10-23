namespace Arrays;

using System;

public class Grid
{
    public static void Main(String[] args)
    {
        
        int[,] grid =
        {
          {1,2,3},
          {4,5,6},
          {7,8,9}  
        };

        Console.WriteLine(grid);
        Console.WriteLine(grid.Length);
        Console.WriteLine(grid[1,2]);
        Console.WriteLine(grid.GetLength(0));
        Console.WriteLine(grid.GetLength(1));

       

         int[,,] g={
            {
                {1,2},
                {3,4}
            },
            {
                {4,5},
                {5,6}
            }
        };

        foreach(int a in g)
        {
            Console.Write(a+" ");
        }
        
    }
}