using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//6 kyu Multiples of 3 or 5
/*public static class Kata
{
    public static int Solution(int value)
    {
        if (value < 0) return 0;

        int sum = 0;

        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}*/
//6 kyu Deep List Reverse
/*public class Kata
{
    public static object[] DeepReverse(object[] l)
    {
        return l.Reverse() .Select(item => item is object[] nestedArray ? DeepReverse(nestedArray) : item).ToArray();
    }
}*/
//6 kyu Reverse or rotate?
/*public class Revrot 
{
    public static string RevRot(string strng, int sz)
    {
        if (sz <= 0 || string.IsNullOrEmpty(strng) || sz > strng.Length) 
            return "";

        var chunks = Enumerable.Range(0, strng.Length / sz).Select(i => strng.Substring(i * sz, sz));

        var transformedChunks = chunks.Select(chunk =>
        {
            var sumOfCubes = chunk.Sum(c => (c - '0') * (c - '0') * (c - '0'));
            return sumOfCubes % 2 == 0 ? new string(chunk.Reverse().ToArray()) : chunk.Substring(1) + chunk[0];     
        });

        return string.Join("", transformedChunks);
    }
}*/
//6 kyu Simple Encryption #1 - Alternating Split
/*public class Kata
{
    public static string Encrypt(string text, int n)
    {
        if (string.IsNullOrEmpty(text) || n <= 0) return text;

        return EncryptHelper(text, n);
    }

    private static string EncryptHelper(string text, int n)
    {
        if (n == 0) return text;

        string odd = string.Concat(text.Where((_, i) => i % 2 != 0));
        string even = string.Concat(text.Where((_, i) => i % 2 == 0));

        string result = odd + even;

        return EncryptHelper(result, n - 1);
    }

    public static string Decrypt(string encryptedText, int n)
    {
        if (string.IsNullOrEmpty(encryptedText) || n <= 0) return encryptedText;

        return DecryptHelper(encryptedText, n);
    }

    private static string DecryptHelper(string encryptedText, int n)
    {
        if (n == 0) return encryptedText;

        int mid = encryptedText.Length / 2;

        string odd = encryptedText.Substring(0, mid);
        string even = encryptedText.Substring(mid);

        char[] result = new char[encryptedText.Length];
        int oddIndex = 0, evenIndex = 0;
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = (i % 2 == 0) ? even[evenIndex++] : odd[oddIndex++];
        }

        return DecryptHelper(new string(result), n - 1);
    }
}*/
//6 kyu Rectangle into Squares
public class SqInRect
{
    public static List<int> sqInRect(int lng, int wdth)
    {
        if (lng == wdth) return null;

        List<int> squares = new List<int>();

        while (lng != 0 && wdth != 0)
        {
            if (lng > wdth)
            {
                squares.Add(wdth);
                lng -= wdth;
            }
            else
            {
                squares.Add(lng);
                wdth -= lng;
            }
        }

        return squares;
    }
}
//6 kyu Sums of Parts
class SumParts
{
    public static int[] PartsSums(int[] ls)
    {
        int n = ls.Length;
        int[] result = new int[n + 1];
        int sum = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            sum += ls[i];
            result[i] = sum;
        }

        return result;
    }
}
//6 kyu Encrypt this!
namespace EncryptThis
{
    public class Kata
    {
        public static string EncryptThis(string input)
        {
            return string.Join(" ", input.Split(' ').Select(EncryptWord));
        }

        private static string EncryptWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;

            string asciiCode = ((int)word[0]).ToString();

            if (word.Length > 2)
            {
                return asciiCode + word[^1] + word.Substring(2, word.Length - 3) + word[1];
            }
            return word.Length == 1 ? asciiCode : asciiCode + word[1];
        }
    }
}
//6 kyu How many double digits?
public static class Kata{
    public static BigInteger NumberOfDuplicates(int barcode){

    BigInteger total = 9 * BigInteger.Pow(10, barcode - 1);

    BigInteger noDuplicates = 9 * BigInteger.Pow(9, barcode - 1);

return total - noDuplicates;

    }
}
//6 kyu Roman Numerals Decoder
public class RomanDecode
{
    public static int Solution(string roman)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int total = 0;
        int previousValue = 0;

        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int currentValue = romanValues[roman[i]];

            if (currentValue < previousValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            previousValue = currentValue;
        }

        return total;
    }
}
//6 kyu Help the bookseller !
public class StockList
{
    public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
    {
        if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
        {
            return "";
        }

        var categoryTotals = lstOf1stLetter.ToDictionary(letter => letter, _ => 0);

        foreach (var art in lstOfArt)
        {
            string category = art[0].ToString();
            int quantity = int.Parse(art.Split(' ')[1]);

            if (categoryTotals.ContainsKey(category))
            {
                categoryTotals[category] += quantity;
            }
        }

        return string.Join(" - ", categoryTotals.Select(kvp => $"({kvp.Key} : {kvp.Value})"));
    }
}
//6 kyu CamelCase Method
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            var words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Concat(words);
        }
    }
//6kyu WeIrD StRiNg CaSe
public class Kata
{
    public static string ToWeirdCase(string s)
    {
        string[] words = s.Split(' ');
        
        for (int i = 0; i < words.Length; i++)
        {
            char[] characters = words[i].ToCharArray();
            
            for (int j = 0; j < characters.Length; j++)
            {
                characters[j] = j % 2 == 0
                    ? char.ToUpper(characters[j])
                    : char.ToLower(characters[j]);
            }
            
            words[i] = new string(characters);
        }
        
        return string.Join(" ", words);
    }
}
//6kyu Replace With Alphabet Position
/*public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        return string.Join(" ", text
            .ToLower()
            .Where(char.IsLetter)
            .Select(c => c - 'a' + 1)); 
    }
}*/
//6kyu Detect Pangram
/*public static class Kata
{
  public static bool IsPangram(string str)
  {
    return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
  }
}*/
//6 kyu Tortoise racing
public class Tortoise
{
    public static int[] Race(int v1, int v2, int g)
    {
        if (v1 >= v2)
        {
            return null; 
        }

        int totalSeconds = (int)(g * 3600.0 / (v2 - v1));
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        return new int[] { hours, minutes, seconds };
    }
}

class _6kyu
{
    static void Main()
    {
        Test1();
    }

    static void Test1()
    {
        bool test1 = AreEqual(Tortoise.Race(720, 850, 70), new int[] { 0, 32, 18 });
        bool test2 = AreEqual(Tortoise.Race(80, 91, 37), new int[] { 3, 21, 49 });
        bool test3 = AreEqual(Tortoise.Race(80, 100, 40), new int[] { 2, 0, 0 });

        Console.WriteLine($"Test1: {(test1 ? "Passed" : "Failed")}");
        Console.WriteLine($"Test2: {(test2 ? "Passed" : "Failed")}");
        Console.WriteLine($"Test3: {(test3 ? "Passed" : "Failed")}");
    }

    static bool AreEqual(int[] actual, int[] expected)
    {
        if (actual.Length != expected.Length) return false;
        for (int i = 0; i < actual.Length; i++)
        {
            if (actual[i] != expected[i]) return false;
        }
        return true;
    }
}
