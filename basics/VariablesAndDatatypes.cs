namespace Basics;

using System;

public class VariablesAndDatatypes
{
    public static void Main(String[] args)
    {
        
        int num;
        num=10;
        Console.WriteLine(num);

        int? n=null;
        Console.WriteLine(n);

        byte b=127;
        Console.WriteLine(b);

        short s=32000;
        Console.WriteLine(s);

        long l=4234325435L;
        Console.WriteLine(l);

        char ch='A';
        Console.WriteLine(ch);

        char c=(char)97;
        Console.WriteLine(c);

        int a='a';
        Console.WriteLine(a);

        float f=3.142F;
        Console.WriteLine(f);

        double d=99.99;
        Console.WriteLine(d);

        decimal dc=43550.988M;
        Console.WriteLine(dc);

        bool @bool = true;
        Console.WriteLine(@bool);

        string myName="Shreyash";
        Console.WriteLine(myName);

        var myFullName="Shreysh Bhagwan Gurav";
        // myFullName=90;
        Console.WriteLine(myFullName);

        int defaultInt=default;
        string? defaultString=default;

        Console.WriteLine(defaultInt+" "+defaultString+" ",default);
        
        Console.WriteLine(sbyte.MaxValue+" "+sbyte.MinValue);
        Console.WriteLine(byte.MaxValue+" "+byte.MinValue);
        Console.WriteLine(short.MaxValue+" "+short.MinValue);
        Console.WriteLine(int.MaxValue+" "+int.MinValue);
        Console.WriteLine(long.MaxValue+" "+long.MinValue);
        Console.WriteLine(float.MaxValue+" "+float.MinValue);
        Console.WriteLine(double.MaxValue+" "+double.MinValue);
        Console.WriteLine(decimal.MaxValue+" "+decimal.MinValue);
        Console.WriteLine(char.MaxValue+" "+char.MinValue);
        
    }
}