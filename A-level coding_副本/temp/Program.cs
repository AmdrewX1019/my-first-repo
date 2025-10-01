using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 19; i++)
        {
            Console.Write((i * i * i) % 19 + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 19; i++)
        {
            Console.Write((i * i * i * i) % 19 + " ");
        }
    }
}