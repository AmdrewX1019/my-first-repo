using System;
using System.Diagnostics;
using System.Text;

class Program {
    static void Wave(string s)
    {
        Console.Write("[");
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (j == i && s[i] != ' ')
                {
                    Console.Write("{0}", (char)(s[j]-' '));
                }
                else
                {
                    Console.Write(s[j]);
                }
            }
            if(i!=s.Length-1){Console.Write(", ");}
        }
        Console.WriteLine("]");
    }
    static void Char_code(string s)
    {
        foreach (char c in s)
        {
            Console.Write((int)c + " ");
        }
    }
    static void Char_codeBYTES(string s)
    {
        byte[] c = Encoding.Default.GetBytes(s);
        foreach (int i in c)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
    static StringBuilder Code_char(int[] a)
    {
        StringBuilder sb = new StringBuilder();//avoid creating lots of strings
        foreach (int i in a)
        {
            sb.Append((char)i);
        }
        return sb;
    }
    static bool Is_anagram(string p, string q)
    {
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();
        foreach (char c in p)
        {
            l1.Add((int)c);
        }
        foreach (char c in q)
        {
            l2.Add((int)c);
        }
        //str to list, then sort alphabytically
        l1.Sort();
        l2.Sort();
        if (l1.Count() == l2.Count())
        {
            for (int i = 0; i < l1.Count(); i++)
            {
                if (l1[i] != l2[i])
                {
                    return false;
                }
            }
            return true;
        }
        else { return false; }
    }
    static int Anagram(string s, string[] t)
    {
        int cnt = 0;
        foreach (string i in t)
        {
            if (Is_anagram(s, i))
            {
                cnt++;
            }
        }
        return cnt;
    }
    static void Main()
    {
        Wave("hello");
        Char_code("hello");//ascii
        Char_code("你好！");//the chinese version of exclamation goes to 65281, while the english one is 33
        Console.WriteLine();
        Char_codeBYTES("hello");
        Char_codeBYTES("你好");//three bytes for each chinese character.
        int[] a = { 65, 110, 100, 114, 101, 119 };
        Console.WriteLine(Code_char(a));
        int[] b = { 206, 188, 206, 174, 206, 187, 206, 191 };
        Console.WriteLine(Code_char(b));//sth.wrong with this
        Debug.Assert(Is_anagram("andrew", "dewran"));
        string[] c = { "maths", "computing", "athms", "thmsa" };
        Debug.Assert(Anagram("maths", c) == 3);
    }
}