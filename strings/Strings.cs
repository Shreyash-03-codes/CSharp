namespace strings;

using System;

public class Strings
{
    public static void Main(String[] args)
    {
        
        String firstName=new string("Shreyash");
        Console.WriteLine(firstName);

        string lastName=new String("Gurav");
        Console.WriteLine(lastName);

        String copyFirstName=firstName;
        String copyButNewObjectOfFirstName = new string("Shreyash");

        Console.WriteLine(firstName==copyFirstName);
        Console.WriteLine(firstName==copyButNewObjectOfFirstName);
        Console.WriteLine(firstName.Equals(copyButNewObjectOfFirstName));
        Console.WriteLine(firstName.GetHashCode()==copyButNewObjectOfFirstName.GetHashCode());
        Console.WriteLine(firstName==lastName);

        // firstName[4]='A';  // strings are immutable in C#

        Console.WriteLine(firstName[0]+" "+firstName[7]); // accessing string elements

        String text="Hello Everyone";


        // some commnly used string functions
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.CompareTo("Hello Every"));
        Console.WriteLine(text.Contains("e"));
        Console.WriteLine(text.EndsWith("one"));
        Console.WriteLine(text.StartsWith("He"));
        Console.WriteLine(text.First());
        Console.WriteLine(text.Last());
        Console.WriteLine(("  "+text+".  ").Trim());
        Console.WriteLine(text.Remove(1,4));
        Console.WriteLine(text.ToCharArray().GetType());
        Console.WriteLine(text.Count());
        Console.WriteLine(text.Length);
        Console.WriteLine(text.Split(' ').GetType());
        Console.WriteLine(string.Join(',',new string[]{"C#","Java","CPP"}));

        String path =@"C:\Users\shreyash\file.txt";
        Console.WriteLine(path);

        String json="""
        {
            "name":"Shreyash Gurav",
            "age":21
        }
        """;

        Console.WriteLine(json);
        

    }
}