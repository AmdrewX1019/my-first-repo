using System.Text;
using System.IO;
using System.Diagnostics;
class Program()
{
    static string Reading(string l)
    {
        string s = File.ReadAllText(l);
        return s;
        /*using (StreamReader SR = new StreamReader("temp.txt"))
        {
            String line = SR.ReadToEnd();
            Console.WriteLine(line);
        }*/
    }
    static void writing(string l, string s)
    {
        File.WriteAllText("temp.txt", s);
        /*using (StreamWriter sw = new StreamWriter("temp.txt"))
        {
            sw.WriteLine(s);
        }*/
    }
    static void Edit(string l)
    {
        if (!File.Exists(l))
        {
            File.Create(l).Close();//always close it!
        }
        string s;
        do
        {
            s = Console.ReadLine();
            File.AppendAllText(l, s + "\n");
        }
        while (s != "");
    }
    static void IncStation()
    {
        foreach (string line in File.ReadLines("stations.txt"))
        {
            if (line.Contains("Station"))
            {
                Console.WriteLine(line);
            }
        }
    }
    static void Station(string s)
    {
        foreach (string line in File.ReadLines("stations.txt"))
        {
            bool temp = true;
            foreach (char c in s)
            {
                if (line.Contains(c))
                {
                    temp = false;
                }
            }
            if (temp)
            {
                Console.WriteLine(line);
            }
        }
    }
    static void Sameletter()
    {
        foreach (string line in File.ReadLines("stations.txt"))
        {
            int Cnt = 0;
            foreach (char c in line)
            {
                if (c == ',')
                {
                    Cnt++;//how many words/commas inside
                }
            }
            if (Cnt == 1)
            {
                for (int i = 0; i < line.Count(); i++)
                {
                    if (line[i] == ',')
                    {
                        if (line[i + 2] == line[0])//go to the beginning of next word
                        {
                            Console.WriteLine(line);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
    static int Cntword(string s, string target)//count how many times target occur in s
    {
        if (s.Count() < target.Count())
        {
            return 0;
        }
        else
        {
            int Cnt = 0;
            for (int i = 0; i <= s.Count() - target.Count();i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = i; j < i + target.Count(); j++)
                {
                    sb.Append(s[j]);
                }
                if (sb.ToString() == target)
                {
                    Cnt++;
                }
            }
            return Cnt;
        }
    }
    static void Moststation()
    {
        string[] lines = new string[]//ugly code(^/\^)
        {
        "Docklands Light Railway",
        "Piccadilly",
        "District",
        "Metropolitan",
        "Circle",
        "Hammersmith & City",
        "Northern",
        "Bakerloo",
        "Jubilee",
        "Central",
        "Victoria",
        "Waterloo & City",
        "Emirates Air Line"
        };
        int max = 0;
        string Ans="";
        string s = Reading("stations.txt");
        foreach (string l in lines)
        {
            if (Cntword(s, l) >= max)
            {
                max = Cntword(s, l);
                Ans = l;
            }
        }
        Console.WriteLine("line {0} has the maxium of {1} stations", Ans, max);
    }
    static void Main()
    {
        Edit("Mew.txt");//Q1
        IncStation();//Q2//none of them contain "station"
        Station("Mackerel");//Q3
        Sameletter();//Q4
        Moststation();//Q5
        Debug.Assert(Cntword(Reading("stations.txt"), "Jubilee") == 27);
    }
}