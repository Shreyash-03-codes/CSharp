namespace Basics;

using System;

public class Operators
{
    public static void Main(String[] args)
    {
        
        int num1=20;
        int num2=10;

        Console.WriteLine("Arithmetic Operators");
        Console.WriteLine(num1+num2);
        Console.WriteLine(num1-num2);
        Console.WriteLine(num1*num2);
        Console.WriteLine(num1/num2);
        Console.WriteLine(num1%num2);

        Console.WriteLine("Comparison operators");
        Console.WriteLine(num1<num2);
        Console.WriteLine(num1<=num2);
        Console.WriteLine(num1>num2);
        Console.WriteLine(num1>=num2);
        Console.WriteLine(num1==num2);
        Console.WriteLine(num1!=num2);

        Console.WriteLine("Assigment operators");
        int num=10;
        Console.WriteLine(num);
        num+=10;
        Console.WriteLine(num);
        num-=5;
        Console.WriteLine(num);
        num*=10;
        Console.WriteLine(num);
        num/=5;
        Console.WriteLine(num);
        num%=3;
        Console.WriteLine(num);

        Console.WriteLine("Logical Operators");
        bool t=true;
        bool f=false;
        Console.WriteLine(t && t);
        Console.WriteLine(t && f);
        Console.WriteLine(f && t);
        Console.WriteLine(f && f);

        Console.WriteLine(t || t);
        Console.WriteLine(t || f);
        Console.WriteLine(t || f);
        Console.WriteLine(f || f);

        Console.WriteLine(!t);
        Console.WriteLine(!f);

        Console.WriteLine("Ternary operators");
        Console.WriteLine(num1>num2?num1+" is max":num2+" is max");

        Console.WriteLine("Bitwise operators");
        Console.WriteLine(num1 & num2);
        Console.WriteLine(num1 | num2);
        Console.WriteLine(num1 ^ num2);
        Console.WriteLine(~num1);
        Console.WriteLine(num1 << num2);
        Console.WriteLine(num1 >> num2);
        
        
        
        
        
        
        

        
        
        
        
        
        

        
    }
}