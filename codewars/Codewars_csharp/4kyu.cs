using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//4 kyu Strings Mix
/*public class Mixing
{
    public static string Mix(string s1, string s2)
    {
        var freq1 = s1.Where(char.IsLower).GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var freq2 = s2.Where(char.IsLower).GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        var result = new List<string>();

        foreach (var c in freq1.Keys.Union(freq2.Keys))
        {
            int count1 = freq1.ContainsKey(c) ? freq1[c] : 0;
            int count2 = freq2.ContainsKey(c) ? freq2[c] : 0;

            if (Math.Max(count1, count2) > 1)
            {
                if (count1 > count2) result.Add($"1:{new string(c, count1)}");
                else if (count2 > count1) result.Add($"2:{new string(c, count2)}");
                else result.Add($"=:{new string(c, count1)}");
            }
        }

        return string.Join("/", result.OrderByDescending(s => s.Length).ThenBy(s => s[0]).ThenBy(s => s));
    }
}*/
//4 kyu Twice linear

/*public class DoubleLinear 
{
    public static int DblLinear(int n) 
    {
        var u = new SortedSet<int> {1}; 
        int count = 0;
        int current = 0;

        while (count <= n)
        {
            current = u.Min; 
            u.Remove(current);
            
            u.Add(2 * current + 1);
            u.Add(3 * current + 1);
            
            count++;
        }

        return current;
    }
}*/
//4 kyu Matrix Determinant
/*public class Matrix
{
   public static int Determinant(int[][] matrix)
   {
       int size = matrix.Length;

       if (size == 1)
       {
           return matrix[0][0];
       }

       if (size == 2)
       {
           return (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
       }

       int determinant = 0;
       for (int i = 0; i < size; i++)
       {
           int[][] minor = GetMinor(matrix, i);
           determinant += (i % 2 == 0 ? 1 : -1) * matrix[0][i] * Determinant(minor);
       }

       return determinant;
   }

   private static int[][] GetMinor(int[][] matrix, int column)
   {
       int size = matrix.Length;
       int[][] minor = new int[size - 1][];

       for (int i = 1; i < size; i++) 
       {
           minor[i - 1] = new int[size - 1];
           int colIndex = 0;
           for (int j = 0; j < size; j++)
           {
               if (j == column)
                   continue; 
               minor[i - 1][colIndex++] = matrix[i][j];
           }
       }

       return minor;
   }
}*/
//4 kyu The observed PIN
/*public static class Kata
{
    public static List<string> GetPINs(string observed)
    {
        var adjacentDigits = new Dictionary<char, string>
        {
            { '1', "124" },
            { '2', "1235" },
            { '3', "236" },
            { '4', "1457" },
            { '5', "24568" },
            { '6', "3569" },
            { '7', "478" },
            { '8', "57890" },
            { '9', "689" },
            { '0', "80" }
        };

        IEnumerable<string> GetCombinations(string prefix, string remaining)
        {
            if (remaining.Length == 0)
            {
                yield return prefix;
                yield break;
            }

            char currentDigit = remaining[0];
            string neighbors = adjacentDigits[currentDigit];

            foreach (char neighbor in neighbors)
            {
                foreach (var combination in GetCombinations(prefix + neighbor, remaining.Substring(1)))
                {
                    yield return combination;
                }
            }
        }

        return new List<string>(GetCombinations("", observed));
    }
}*/
//4 kyu Pyramid Slide Down
/*public class PyramidSlideDown
{
    public static int LongestSlideDown(int[][] pyramid)
    {
        for (int row = pyramid.Length - 2; row >= 0; row--)
        {
            for (int col = 0; col < pyramid[row].Length; col++)
            {
                pyramid[row][col] += Math.Max(pyramid[row + 1][col], pyramid[row + 1][col + 1]);
            }
        }
        return pyramid[0][0];
    }
}*/
//4kyu Sum Strings as Numbers
/*public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      BigInteger aInt;
      BigInteger bInt;
      
      BigInteger.TryParse(a, out aInt);
      BigInteger.TryParse(b, out bInt);
      
      return (aInt + bInt).ToString();
    }
}*/
//4kyu Catching Car Mileage Numbers
/*public static class Kata
{
    public static int IsInteresting(int number, List<int> awesomePhrases)
    {
        if (number < 98) return 0;
        if (number == 98 || number == 99) return 1;

        if (IsInterestingNumber(number, awesomePhrases)) return 2;
        if (IsInterestingNumber(number + 1, awesomePhrases) || IsInterestingNumber(number + 2, awesomePhrases)) return 1;

        return 0;
    }

    private static bool IsInterestingNumber(int number, List<int> awesomePhrases)
    {
        if (number < 100) return false;

        string numStr = number.ToString();
        return awesomePhrases.Contains(number) ||
               IsAllZeros(numStr) ||
               IsSameDigit(numStr) ||
               IsSequential(numStr, true) ||
               IsSequential(numStr, false) ||
               IsPalindrome(numStr);
    }

    private static bool IsAllZeros(string numStr)
    {
        return numStr[1..].Trim('0').Length == 0;
    }

    private static bool IsSameDigit(string numStr)
    {
        return numStr.Trim(numStr[0]).Length == 0;
    }

    private static bool IsSequential(string numStr, bool incrementing)
    {
        string sequence = incrementing ? "1234567890" : "9876543210";
        return sequence.Contains(numStr);
    }

    private static bool IsPalindrome(string numStr)
    {
        char[] reversed = numStr.ToCharArray();
        Array.Reverse(reversed);
        return new string(reversed) == numStr;
    }
}*/
//4kyu Adding Big Numbers
/*public class Kata
{
    public static string Add(string a, string b)
    {
        StringBuilder result = new StringBuilder();

        int carry = 0;
        int i = a.Length - 1;
        int j = b.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digitA = i >= 0 ? a[i] - '0' : 0; 
            int digitB = j >= 0 ? b[j] - '0' : 0; 

            int sum = digitA + digitB + carry;
            carry = sum / 10; 
            result.Insert(0, sum % 10);

            i--; 
            j--; 
        }

        return result.ToString(); 
    }
}*/
//4 kyu Next bigger number with the same digits
/*using System;

public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        char[] digits = n.ToString().ToCharArray();
        int i = digits.Length - 2;

        while (i >= 0 && digits[i] >= digits[i + 1])
        {
            i--;
        }

        if (i < 0) return -1;

        int j = digits.Length - 1;
        while (digits[j] <= digits[i])
        {
            j--;
        }

        char temp = digits[i];
        digits[i] = digits[j];
        digits[j] = temp;

        Array.Sort(digits, i + 1, digits.Length - i - 1);

        long result = long.Parse(new string(digits));
        return result > n ? result : -1;
    }
}*/
//4 kyu So Many Permutations!
class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        var results = new HashSet<string>();
        Permute(s.ToCharArray(), 0, s.Length - 1, results);
        return results.ToList();
    }

    private static void Permute(char[] chars, int left, int right, HashSet<string> results)
    {
        if (left == right)
        {
            results.Add(new string(chars));
            return;
        }

        for (int i = left; i <= right; i++)
        {
            Swap(chars, left, i);
            Permute(chars, left + 1, right, results);
            Swap(chars, left, i);
        }
    }

    private static void Swap(char[] chars, int i, int j)
    {
        char temp = chars[i];
        chars[i] = chars[j];
        chars[j] = temp;
    }
}

class _4kyu
{
    static void Main()
    {
        Example1();
        Example2();
        Example3();
    }

    static void Example1()
    {
        Assert.That(
            Permutations.SinglePermutations("a").OrderBy(x => x).ToList(),
            Is.EqualTo(new List<string> { "a" })
        );
    }

    static void Example2()
    {
        Assert.That(
            Permutations.SinglePermutations("ab").OrderBy(x => x).ToList(),
            Is.EqualTo(new List<string> { "ab", "ba" })
        );
    }

    static void Example3()
    {
        Assert.That(
            Permutations.SinglePermutations("aabb").OrderBy(x => x).ToList(),
            Is.EqualTo(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" })
        );
    }
}
