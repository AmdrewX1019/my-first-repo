using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
class Program
{
    static void Q1()
    {
        Console.WriteLine("enter minutes");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("enter seconds");
        int sec = int.Parse(Console.ReadLine());
        double s = min * 60 + sec;
        Console.WriteLine("{0:0.00}m/s", 10000 / s);//10000m devided by sec
        double h = (double)min / 60 + (double)sec / 3600;
        Console.WriteLine("{0:0.00}mph", 6.25 / h);//6.25miles devided by h
    }
    static void Q2()
    {
        Console.WriteLine("please enter a number");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= x; j++)
            {
                Console.Write("{0,2}*{1,2}={2,3} ", i, j, i * j);//(x,y)means x occupy y spaces(chat gpt)
                //Console.Write("{0}*{1}={2} ", i, j, i*j);
                //not sure what the extension means
            }
            Console.Write("\n");//new line
        }
    }
    static void Q3()
    {
        double pi = Math.PI;//google
        double r = 0, c = 0, s = 0;
        Console.WriteLine("please enter which of radius, circumference, and area you'd like to give");
        string deci = Console.ReadLine();
        if (deci == "radius")
        {
            Console.WriteLine("please enter radius");
            r = double.Parse(Console.ReadLine());
            //2 decimal places:{x:0.00} (https://www.bytehide.com/blog/decimal-csharp)
            c = 2 * pi * r;
            s = pi * r * r;
            Console.WriteLine("the circle's area is {0:0.00} ", s);
            Console.WriteLine("the circle's circumference is {0:0.00} ", c);
        }
        if (deci == "circumference")
        {
            Console.WriteLine("please enter circumference");
            c = double.Parse(Console.ReadLine());
            r = c / (2 * pi);
            s = pi * r * r;
            Console.WriteLine("the circle's radius is {0:0.00} ", r);
            Console.WriteLine("the circle's area is {0:0.00} ", s);
        }
        if (deci == "area")
        {
            Console.WriteLine("please enter area");
            s = double.Parse(Console.ReadLine());
            //use Math.Pow(x,y) to represent x^y
            r = Math.Pow(s / pi, 0.5);//https://www.geeksforgeeks.org/c-sharp/c-sharp-math-pow-method/
            c = 2 * pi * r;
            Console.WriteLine("the circle's radius is {0:0.00} ", r);
            Console.WriteLine("the circle's circumference is {0:0.00} ", c);
        }
    }
    //I'll start a new project for extension of pi calculation
    static void Main()
    {
        string deci = "";
        int input = 0;
        while (deci != "leave")
        {
            Console.WriteLine("please select which question to do");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Q1();
            }
            if (input == 2)
            {
                Q2();
            }
            if (input == 3)
            {
                Q3();
            }
            Console.WriteLine("do you want to continue or leave?");
            deci = Console.ReadLine();
        }
    }
}