using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int Digitsum(int x)
    {
        Debug.Assert(x >= 0, "x has to be positive");
        int sum = 0;
        while (x >= 1)
        {
            sum += x % 10;
            x /= 10;
        }
        return sum;
    }
    static bool Isprime(int x)
    {
        //Debug.Assert(x >= 0);
        for (int i = 2; i <= x - 1; i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static int Strspace(string y)
    {
        int sum = 0;
        for (int i = 0; i < y.Length; i++)
        {
            if (y[i] == ' ')
            {
                sum++;
                //Console.WriteLine("there are {0} spaces", sum);
            }
        }
        return sum;
    }
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    static string ToBinary(int x)
    {
        //Debug.Assert(x >= 0);
        string result = "";
        while (x > 0)
        {
            result = Convert.ToString(x % 2) + result;
            x /= 2;
        }
        return result;
    }
    static string ToHex(int x)
    {
        //Debug.Assert(x >= 0);
        string result = "";
        while (x > 0)
        {
            if (x % 16 < 10)
            {
                result = Convert.ToString(x % 16) + result;
            }
            else
            {
                switch (x % 16)
                {
                    case 10:
                        result = result + "A";
                        break;
                    case 11:
                        result = result + "B";
                        break;
                    case 12:
                        result = result + "C";
                        break;
                    case 13:
                        result = result + "D";
                        break;
                    case 14:
                        result = result + "E";
                        break;
                    case 15:
                        result = result + "F";
                        break;
                    default:
                        break;
                }
            }
            x /= 16;
        }
        return (result);
    }
    static void Q2(int x, int y)
    {
        Debug.Assert(x > 0 && x<30);
        Debug.Assert(y > 0 && y<30);
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= y; j++)
            {
                Console.Write("{0,2}*{1,2}={2,3} ", i, j, i * j);//(x,y)means x occupy y spaces(chat gpt)
                //Console.Write("{0}*{1}={2} ", i, j, i*j);
            }
            Console.Write("\n");//new line
        }
    }
    static void Main()
    {
        //Console.WriteLine();
        Digitsum(123);
        Isprime(47);
        ToBinary(123);
        ToHex(123);
    }
}
