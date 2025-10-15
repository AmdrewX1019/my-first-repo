using System;
using System.Diagnostics;

class Program
{

    static int Getrm(int x)
    {
        return x & 1;
    }
    static int Get3rm(int x)
    {
        return x & 7;
    }
    static int Get4rm(int x)
    {
        return x & 15;
    }
    static int Getlm(int x)
    {
        if (x >= 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    static int Get3lm(int x)
    {
        x = x >> 29;
        return x & 7;
    }
    static int Remrm(int x)
    {
        return x & (~1);
    }
    static int Rem3rm(int x)
    {
        return x & (~111);
    }
    static int Remlm(int x)
    {
        return x & (~(1 << 31));
    }
    static int Rem3lm(int x)
    {
        return x & (~(111 << 29));
    }
    static void Main()
    {
        Console.WriteLine(Convert.ToString(Remrm(7), 2));//int to base 2 string
        Debug.Assert(Get3lm(-1) == 7);
        Debug.Assert(Get3rm(15) == 7);
        Debug.Assert(Rem3rm(7) == 0);
        Debug.Assert(Remlm(-2147483648) == 0);
        Debug.Assert(Rem3lm(-2147483648) == 0);
        Debug.Assert(Remrm(Get4rm(15))==14);
    }
}