using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
       
        power(49, 71, 2);
        Console.WriteLine(CountSockPairs("AABBCC"));
        Console.WriteLine(LongestCommonSuffix("multiplication", "substraction"));

        Console.WriteLine("\n--- Task 4 ---");
        ProcessList(new List<int> { 5, 5 });
        ProcessList(new List<string> { "test", "random", "programming", "word" });
        ProcessList(new List<bool> { true, false, true, false, true, false, false });

        Console.WriteLine("\n--- Task 5 ---");
        PrintDigits(12345);

        Console.WriteLine("\n--- Task 6 ---");
        Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));  // true
        Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));  // false
    }


    static void power(int a, int b, int n)
    {
        int count = 0;

        for (int i = 1; Math.Pow(i, n) <= b; i++)
        {
            double power = Math.Pow(i, n);
            if (power >= a && power <= b)
            {
                Console.WriteLine($"{i}^{n} = {power}");
                count++;
            }
        }

        Console.WriteLine($"Total count: {count}");
    }


    static int CountSockPairs(string socks)
    {
        return socks
            .GroupBy(c => c)
            .Select(g => g.Count() / 2)
            .Sum();
    }

    static string LongestCommonSuffix(string s1, string s2)
    {
        int i = s1.Length - 1;
        int j = s2.Length - 1;
        string suffix = "";

        while (i >= 0 && j >= 0 && s1[i] == s2[j])
        {
            suffix = s1[i] + suffix;
            i--;
            j--;
        }

        return suffix;
    }

    // ====== Task 4 ======
    static void ProcessList<T>(List<T> list)
    {
        if (typeof(T) == typeof(string))
        {
            foreach (var item in list.Cast<string>())
                Console.WriteLine(item.ToUpper());
        }
        else if (typeof(T) == typeof(int))
        {
            int sum = list.Cast<int>().Sum();
            Console.WriteLine(sum);
        }
        else if (typeof(T) == typeof(bool))
        {
            var boolList = list.Cast<bool>().ToList();
            Console.WriteLine($"First Element is {boolList.First()}");
            Console.WriteLine($"Last Element is {boolList.Last()}");
            Console.WriteLine($"Middle Element is {boolList[boolList.Count / 2]}");
        }
        else
        {
            Console.WriteLine("Unsupported type");
        }
    }

    // ====== Task 5 ======
    static void PrintDigits(int number)
    {
        string str = number.ToString();
        PrintRec(str, 0);
    }

    static void PrintRec(string str, int index)
    {
        if (index == str.Length) return;

        Console.Write(str[index]);
        if (index != str.Length - 1) Console.Write(" - ");

        PrintRec(str, index + 1);
    }

    // ====== Task 6 ======
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!seen.Add(num))
                return true; 
        }

        return false;
    }
}
