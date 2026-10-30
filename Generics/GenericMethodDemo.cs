using System;

namespace Generics
{

    public class Display
    {
        public void ShowArray<T>(T[]arr)
        {
            foreach(T a in arr)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
        }
    }
    public class GenericsMethodDemo
    {
        public static void Main(String[] args)
        {
            Display display=new Display();
            display.ShowArray(new int[]{5,6,3,9,12,3,0});
            display.ShowArray(new string[]{"shreyash","gurav","batman"});
        }
    }
}