//7_1
using System;
using System.Collections.Generic;

class Program
{
    public static List<int> Multiples(int m, int n)
    {
        List<int> result = new List<int>();
        
        for (int i = 1; i <= m; i++)
        {
            result.Add(i * n);
        }
        
        return result;
    }
}

//7_2
using System;
using System.Text.RegularExpressions;

class Program
{
    public static string Disemvowel(string str)
    {
        return Regex.Replace(str, "[aeiouAEIOU]", "");
    }
}

//7_3
using System;

class Program
{
    public static int SquareDigits(int num)
    {
        string numStr = num.ToString();
        string result = "";

        foreach (char c in numStr)
        {
            int digit = int.Parse(c.ToString());
            result += (digit * digit).ToString();
        }

        return int.Parse(result);
    }
}
