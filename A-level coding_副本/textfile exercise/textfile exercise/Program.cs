using System.Text;
using System.IO;
class Program()
{
    static void Reading(string l)
    {
        string s = File.ReadAllText(l);
        Console.WriteLine(s);
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
                    Cnt++;//how many words inside
                }
            }
            if (Cnt ==1)
            {
                for (int i = 0; i < line.Count(); i++)
                {
                    if (line[i] == ',')
                    {
                        if (line[i + 2] == line[0])
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
    static void Moststations()
    {
        
    }
    static void Main()
    {
        //Edit("Mew.txt");
        IncStation();//none of them contain station?
        Station("Mackerel");
        Sameletter();
    }
}