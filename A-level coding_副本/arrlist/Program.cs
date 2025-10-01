using System;
using System.Diagnostics;

class Program
{
    static void Q1(List<int> l)//1
    {
        int Sum = 0, Max = l[1], Min = l[1];
        List<int> ans = new List<int>();
        foreach (int i in l)
        {
            if (i > Max)
            {
                Max = i;
            }
            if (i < Min)
            {
                Min = i;
            }
            if (i < 0)
            {
                ans.Add(i);
            }
            Sum += i;
        }
        Console.WriteLine("The sum is {0}\nThe maxium is {1}\nThe minium is {2}", Sum, Max, Min);
        foreach (int i in ans)
        {
            Console.Write(i);
        }
    }
    static void Printlist<T>(List<T> l)//2
    {
        int cnt = 0;
        foreach (T i in l)
        {
            Console.WriteLine("[{0}]={1}", cnt, i);
            cnt++;
        }
    }
    static bool Exactsame(List<int> l1, List<int> l2)//3
    {
        l1.Sort();
        l2.Sort();
        if (l1.Count() == l2.Count()){
            for (int i = 0; i < l1.Count(); i++) {
                if (l1[i] != l2[i])
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
    static bool Iselementsame(List<int> l1, List<int> l2)//4
    {
        foreach (int i in l1)//every l1 found in l2
        {
            bool temp = false;
            foreach (int j in l2)
            {
                if (i == j)
                {
                    temp = true;
                }
            }
            if (temp == false)
            {
                return false;
            }
        }
        foreach (int i in l2)//every l2 found in l1
        {
            bool temp = false;
            foreach (int j in l1)
            {
                if (i == j)
                {
                    temp = true;
                }
            }
            if (temp == false)
            {
                return false;
            }
        }
        return true;
    }
    static bool BinarySearch(List<int> l, int x)//this one should work
    {
        int Front = 0, Back = l.Count(), mid = 0;
        do
        {
            mid = (Front + Back) / 2;
            if (l[mid] == x)
            {
                return true;
            }
            else if (l[mid] > x)
            {
                Back = mid;
            }
            else
            {
                Front = mid;
            }
        } while (Front != Back - 1);//where there's still item to check
        return false;
    }
    static List<int> Duplicate(List<int> l)//6
    {
        List<int> ans = new List<int>();
        int[] R = new int[l.Max()-l.Min()+1];//to store the number of each element, means i appears R[i-l.min()] times
        foreach (int i in l)
        {
            R[i-l.Min()]++;//non-negative index!
        }
        for (int i = 0; i < l.Max()-l.Min(); i++)
        {
            if (R[i] >= 2)
            {
                ans.Add(i+l.Min());
            }
        }
        return ans;
    }
    static bool Issublist(List<int> l1, List<int> l2)//7
    {
        if (l1.Count() >= l2.Count())
        {
            for (int i = 0; i < l2.Count(); i++)
            {
                bool temp = false;
                for (int j = 0; j < l1.Count(); j++)
                {
                    if (l2[i] == l1[j])
                    {
                        l1[j] = l2.Max() + 1;
                        //represent this number been"counted/used"
                        //and assign it a value that won't be retrieved again.
                        temp = true;
                        break;
                    }
                }
                if (!temp)
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            for (int i = 0; i < l1.Count(); i++)
            {
                bool temp = false;
                for (int j = 0; j < l2.Count(); j++)
                {
                    if (l2[j] == l1[i])
                    {
                        l2[j] = l1.Max() + 1;
                        temp = true;
                        break;
                    }
                }
                if (!temp)
                {
                    return false;
                }
            }
            return true;
        }
    }
    static List<int> Reverse(List<int> l)//8
    {
        List<int> ans = new List<int>();
        for (int i = l.Count() - 1; i >= 0; i--)
        {
            ans.Add(l[i]);
        }
        return ans;
    }
    static void Main()
    {
        List<int> l1 = new List<int> { 3, 3, 4, 5, 6, 7 };
        List<int> l2 = new List<int> { 3, 3, 4, 5 };
        Printlist(l1);
        Q1(l1);
        Debug.Assert(Exactsame(l1, l2) == false);
        Debug.Assert(Iselementsame(l1, l2) == false);
        Debug.Assert(BinarySearch(l2, 4) == true);
        Printlist(Duplicate(l1));
        Printlist(Reverse(l1));
        Debug.Assert(Issublist(l1, l2) == true);//this function makes change to the original list(s), so I place it at the end
    }
}