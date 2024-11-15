//6_1
using System;
using System.Collections.Generic;

class Program
{
    public static string ExpandedForm(int n)
    {
        string numStr = n.ToString();
        int length = numStr.Length;
        List<string> result = new List<string>();

        for (int i = 0; i < length; i++)
        {
            char digit = numStr[i];

            if (digit != '0')
            {
                int expanded = int.Parse(digit.ToString()) * (int)Math.Pow(10, length - i - 1);
                result.Add(expanded.ToString());
            }
        }

        return string.Join(" + ", result);
    }
}
//6_2
using System;
using System.Collections.Generic;

class Program
{
    public static string ExpandedForm(double num)
    {
        string[] parts = num.ToString().Split('.');
        string integerPart = parts[0];
        string fractionalPart = parts.Length > 1 ? parts[1] : string.Empty;

        List<string> result = new List<string>();

        // Целая часть
        for (int i = 0; i < integerPart.Length; i++)
        {
            char digit = integerPart[i];
            if (digit != '0')
            {
                result.Add(digit + new string('0', integerPart.Length - i - 1));
            }
        }

        // Дробная часть
        for (int i = 0; i < fractionalPart.Length; i++)
        {
            char digit = fractionalPart[i];
            if (digit != '0')
            {
                result.Add($"{digit}/{Math.Pow(10, i + 1)}");
            }
        }

        return string.Join(" + ", result);
    }

    static void Main()
    {
        Console.WriteLine(ExpandedForm(12.34)); 
    }
}
//6_3
using System;

class Program
{
    public static int DigitalRoot(int n)
    {
        while (n >= 10)
        {
            n = SumOfDigits(n);
        }
        return n;
    }

    private static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(DigitalRoot(12345)); 
    }
}

