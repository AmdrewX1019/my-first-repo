using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter n");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        //Console.WriteLine(n * (n+1) / 2);
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}
