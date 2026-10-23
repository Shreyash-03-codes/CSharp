namespace Methods;

using System;

public class ParamsParameter
{

    public static void ShowWords(params string[] words)
    {
        foreach(string word in words)
        {
            Console.Write(word+" ");
        }
        Console.WriteLine();
    }
    public static void Main(String[] args)
    {
        ShowWords();
        ShowWords("Hey","Hello","hi","shreyash");
        ShowWords("Batman");
        ShowWords("cat","dog","fish");
        
    }
}