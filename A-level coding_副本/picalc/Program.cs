using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int s = 0;
        for (int i = 1; i <= 20081019; i++)//birthday, could go even bigger
        {
            double x = rnd.NextDouble();//a random float between 0 and 1
            double y = rnd.NextDouble();//a random float between 0 and 1
            double d_2 = Math.Pow(x - 0.5, 2) + Math.Pow(y - 0.5, 2);
            if (d_2 <= 0.5 * 0.5)//distance^2<=r^2 ==> point inside circle
            {
                s += 1;//note how many points will lie in circle
            }
        }
        //note that integer devide integer becomes integer(lower bond)
        double pb = s / 20081019.0;//probability of point lie in circle(mathmatically close to pi/4)
        Console.WriteLine("the value of pi is roughly {0}", pb * 4.0);
    }
}
