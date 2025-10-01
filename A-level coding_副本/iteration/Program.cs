using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Countdown(int x)
    {
        while (x >= 0)
        {
            Console.WriteLine(x);
            x--;
        }
        Console.WriteLine("blast-off");
    }
    static void DrawTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    
    static void DrawRectangle(int x, int y)
    {
        for (int i = 1; i <= 2 * x + 1; i++)
        {
            for (int j = 1; j <= 4 * y + 1; j++)
            {
                if (i % 2 == 1)
                {
                    if (j % 4 == 1)
                    {
                        Console.Write("+");
                    }
                    else Console.Write("-");
                }
                else
                {
                    if (j % 4 == 1)
                    {
                        Console.Write("|");
                    }
                    else Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    static void Ask(int x)
    {
        int Sum = 0;
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine("please enter number");
            Sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("the sum of numbers is {0}", Sum);
        Console.WriteLine("the average is {0}", Convert.ToDouble(Sum / x));
    }
    static bool Isprime(int x)
    {
        int i = 2;
        while (i < x)
        {
            if (x % i == 0)
            {
                return false;
            }
            i++;
        }
        return true;
    }
    static bool Isperfect(int x)
    {
        int i = 1, sum=0;
        while (i < x)
        {
            if (x % i == 0)
            {
                sum += i;
            }
            i++;
        }
        return sum == x;
    }
    static bool Isabundant(int x)
    {
        int i = 1, sum=0;
        while (i < x)
        {
            if (x % i == 0)
            {
                sum += i;
            }
            i++;
        }
        return sum > x;
    }
    static bool Isfriendly(int x, int y)
    {
        int i = 1, j = 1, sumx = 0, sumy = 0;
        while (i < x)
        {
            if (x % i == 0)
            {
                sumx += i;
            }
            i++;
        }
        while (j < y)
        {
            if (y % j == 0)
            {
                sumy += j;
            }
            j++;
        }
        return Convert.ToDouble(sumx/x)==Convert.ToDouble(sumy/y);
    }
    static void Menu()
    {
        int q;
        do
        {
            Console.WriteLine("which question you'd like to do?");
            q = Convert.ToInt32(Console.ReadLine());
        }
        while (q != 1 && q != 2 && q != 3 && q != 4 && q != 5 && q != 6 && q != 7 && q != 8);
        switch (q)
        {
            case 1:
                Countdown(10);
                break;
            case 2:
                DrawTriangle(5);
                break;
            case 3:
                DrawRectangle(5, 4);
                break;
            case 4:
                Ask(5);
                break;
            case 5:
                Console.WriteLine(Isprime(2021));
                break;
            case 6:
                Console.WriteLine(Isperfect(6));
                break;
            case 7:
                Console.WriteLine(Isabundant(12));
                break;
            case 8:
                Console.WriteLine(Isfriendly(30, 140));
                break;
            default:
                break;
        }
    }
    static void bs(int x) {
        int a = 0, b = 1000, mid=0;
        while (mid != x)
        {
            mid = (a + b) / 2;
            if (x > mid) {
                a = mid;
            }
            else if (x < mid) {
                b = mid;
            }
            else {
                Console.WriteLine("found");
            }
        }
    }
    static void Main()
    {
        Menu();
        bs(50);
    }
}