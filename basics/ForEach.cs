namespace basics;

using System;

public class ForEach
{
    public static void Main(String[] args)
    {
        
        string[]langs={"C#","Java","C","CPP"};

        foreach (string lang in langs)
        {
            Console.WriteLine(lang);
        }
    }
}