using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using NUnit.Framework;

//3 kyu Binomial Expansion
/*public class KataSolution
{
    public static string Expand(string expr)
    {
        var match = System.Text.RegularExpressions.Regex.Match(expr, @"\(([-+]?\d*)?([a-z])([+-]\d+)\)\^(\d+)");
        if (!match.Success) throw new ArgumentException("Invalid Input");

        int a = string.IsNullOrEmpty(match.Groups[1].Value) || match.Groups[1].Value == "+" ? 1 :
                match.Groups[1].Value == "-" ? -1 : int.Parse(match.Groups[1].Value);
        char variable = match.Groups[2].Value[0];
        int b = int.Parse(match.Groups[3].Value);
        int n = int.Parse(match.Groups[4].Value);

        if (n == 0) return "1";

        var result = new StringBuilder();

        for (int k = 0; k <= n; k++)
        {
            long binomialCoeff = BinomialCoefficient(n, k);
            long coeff = binomialCoeff * (long)Math.Pow(a, n - k) * (long)Math.Pow(b, k);
            int power = n - k;

            if (coeff == 0) continue;

            if (result.Length > 0 && coeff > 0)
                result.Append("+");

            if (coeff == -1 && power > 0) result.Append("-");
            else if (coeff != 1 || power == 0) result.Append(coeff);

            if (power > 0)
            {
                result.Append(variable);
                if (power > 1) result.Append("^" + power);
            }
        }

        return result.ToString();
    }

    private static long BinomialCoefficient(int n, int k)
    {
        if (k == 0 || k == n) return 1;
        long result = 1;
        for (int i = 1; i <= k; i++)
        {
            result = result * (n - (k - i)) / i;
        }
        return result;
    }
}*/
//3 kyu Rail Fence Cipher: Encoding and Decoding
public class RailFenceCipher
{
    public static string Encode(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n < 2) return s;

        List<char>[] rails = new List<char>[n];
        for (int i = 0; i < n; i++) rails[i] = new List<char>();

        int rail = 0;
        int direction = 1; 

        foreach (char c in s)
        {
            rails[rail].Add(c);
            rail += direction;

            if (rail == 0 || rail == n - 1)
                direction *= -1;
        }

        return string.Join("", rails.SelectMany(r => r));
    }

    public static string Decode(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n < 2) return s;

        int[] railLengths = new int[n];
        int rail = 0;
        int direction = 1;

        for (int i = 0; i < s.Length; i++)
        {
            railLengths[rail]++;
            rail += direction;

            if (rail == 0 || rail == n - 1)
                direction *= -1;
        }

        List<char>[] rails = new List<char>[n];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            rails[i] = new List<char>(s.Substring(index, railLengths[i]).ToCharArray());
            index += railLengths[i];
        }

        char[] decoded = new char[s.Length];
        rail = 0;
        direction = 1;

        for (int i = 0; i < s.Length; i++)
        {
            decoded[i] = rails[rail][0];
            rails[rail].RemoveAt(0);
            rail += direction;

            if (rail == 0 || rail == n - 1)
                direction *= -1;
        }

        return new string(decoded);
    }
}
class _3kyu
{
    static void Main()
    {
        EncodeSampleTests();
        DecodeSampleTests();
    }

    static void EncodeSampleTests()
    {
        string[][] encodes =
        {
            new[] { "WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN" },
            new[] { "Hello, World!", "Hoo!el,Wrdl l" },    
            new[] { "Hello, World!", "H !e,Wdloollr" },   
            new[] { "", "" }                              
        };
        int[] rails = { 3, 3, 4, 3 };
        for (int i = 0; i < encodes.Length; i++)
        {
            Assert.AreEqual(encodes[i][1], RailFenceCipher.Encode(encodes[i][0], rails[i]));
        }
    }

    static void DecodeSampleTests()
    {
        string[][] decodes =
        {
            new[] { "WECRLTEERDSOEEFEAOCAIVDEN", "WEAREDISCOVEREDFLEEATONCE" }, 
            new[] { "H !e,Wdloollr", "Hello, World!" },  
            new[] { "", "" }                               
        };
        int[] rails = { 3, 4, 3 };
        for (int i = 0; i < decodes.Length; i++)
        {
            Assert.AreEqual(decodes[i][1], RailFenceCipher.Decode(decodes[i][0], rails[i]));
        }
    }
}
