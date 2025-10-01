using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void F1()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x == y)
        {
            Console.WriteLine("they are equal");
        }
        else
        {
            Console.WriteLine("they are not equal");
        }
    }
    static void F2()
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("{0} is even", x);
        }
        else {
            Console.WriteLine("{0} is odd", x);
        }
    }
    static void F3()
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 100 == 0)
        {
            if (x % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
        else
        {
            if (x % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
    static void F4()
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 3 == 0 && x % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (x % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (x % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine("{0}", x);
        }
    }
    static void F5()
    {
        int x = int.Parse(Console.ReadLine());
        int SF = 0;
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                SF++;
            }
        }
        Console.WriteLine(SF);
    }
    static void F6()
    {
        string x = Console.ReadLine();
        switch (x)
        {
            case "a":
                Console.WriteLine("vowel");
                break;
            case "e":
                Console.WriteLine("vowel");
                break;
            case "i":
                Console.WriteLine("vowel");
                break;
            case "o":
                Console.WriteLine("vowel");
                break;
            case "u":
                Console.WriteLine("vowel");
                break;
            default://no case match
                Console.WriteLine("not vowel");
                break;
        }
    }
    static void F7()
    {
        int block = 512;
        double x = double.Parse(Console.ReadLine());
        Console.Write("blocks required = ");
        if (x * 1024.0 % block == 0)
        {
            Console.WriteLine(x * 2);
        }
        else
        {
            Console.WriteLine((int)x * 1024 / 512 + 1);
        }
    }
    static void F8()
    {
        double x = double.Parse(Console.ReadLine());
        double per = double.Parse(Console.ReadLine());
        double week = x * per / 100.0;
        Console.WriteLine("each week you save "+ week);
        Console.WriteLine("each year you save "+ week * 53);//53 weeks in one year
    }
    static void F9()
    {
        
    }
    static void Main()
    {
        F8();
    }
}
