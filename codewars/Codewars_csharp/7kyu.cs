using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//7 kyu Round up to the next multiple of 5
public class Kata
{
  public static int RoundToNext5(int n)
  {
    return (n % 5 == 0) ? n : n - (n % 5) + (n > 0 ? 5 : 0);
  }
}
//7 kyu Deodorant Evaporator
public class Evaporator
{
    public static int evaporator(double content, double evap_per_day, double threshold)
    {
        double currentContent = content;
        double thresholdContent = content * (threshold / 100);
        int days = 0;

        while (currentContent > thresholdContent)
        {
            currentContent -= currentContent * (evap_per_day / 100);
            days++;
        }

        return days;
    }
}
//7 kyu Largest 5 digit number in a series
public class Kata
{
    public static int GetNumber(string str)
    {
        int maxSequence = 0;

        for (int i = 0; i <= str.Length - 5; i++)
        {
            int currentSequence = int.Parse(str.Substring(i, 5));
            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }
        }

        return maxSequence;
    }
}
//7 kyu Alternate capitalization
public static class Kata
{
    public static string[] Capitalize(string s)
    {
        char[] evenIndexed = s.ToCharArray();
        char[] oddIndexed = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenIndexed[i] = char.ToUpper(evenIndexed[i]);
                oddIndexed[i] = char.ToLower(oddIndexed[i]);
            }
            else
            {
                evenIndexed[i] = char.ToLower(evenIndexed[i]);
                oddIndexed[i] = char.ToUpper(oddIndexed[i]);
            }
        }

        return new string[] { new string(evenIndexed), new string(oddIndexed) };
    }
}
//7 kyu Sum of Minimums!
class Kata
{
    public static int SumOfMinimums(int[,] numbers)
    {
        int sum = 0;
        int rows = numbers.GetLength(0);
        int cols = numbers.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < cols; j++)
            {
                if (numbers[i, j] < min)
                {
                    min = numbers[i, j];
                }
            }
            sum += min;
        }

        return sum;
    }
}
//7 kyu Sum of angles
public class Kata
{
    public static int Angle(int n)
    {
        return (n - 2) * 180;
    }
}
//7 kyu Number of Decimal Digits
public class DecTools
{
    public static int Digits(ulong n)
    {
        return n.ToString().Length;
    }
}
//7 kyu Predict your age!
public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
    {
        List<int> ages = new List<int> { age1, age2, age3, age4, age5, age6, age7, age8 };
        
        int sumOfSquares = ages.Select(age => age * age).Sum();

        double result = Math.Sqrt(sumOfSquares) / 2;

        return (int)Math.Floor(result);
    }
}
//7 kyu Digitize
public static class Kata
{
  public static int[] digitize(int n)
  {
    return n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
  }
}
//7 kyu Don't give me five!
public class Kata
{
    public static int DontGiveMeFive(int start, int end)
    {
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (!i.ToString().Contains('5'))
            {
                count++;
            }
        }

        return count;
    }
}
//7 kyu Reverse words
public static class Kata
{
    public static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        return string.Join(" ", words);
    }
}
//7 kyu Product Of Maximums Of Array (Array Series #2)
public class Kata
{
    public static int MaxProduct(int[] arr, int size)
    {
        int[] maxNumbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            int maxIndex = -1;
            int maxValue = int.MinValue;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > maxValue)
                {
                    maxValue = arr[j];
                    maxIndex = j;
                }
            }

            maxNumbers[i] = maxValue;

            arr[maxIndex] = int.MinValue;
        }

        int product = 1;
        foreach (int num in maxNumbers)
        {
            product *= num;
        }

        return product;
    }
}
//7 kyu Remove All The Marked Elements of a List*/
public class Kata
{
    public static int[] Remove(int[] integerList, int[] valuesList)
    {
        return integerList.Where(num => !valuesList.Contains(num)).ToArray();
    }
}
//7 kyu Check the exam
public static class Kata
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int score = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr2[i] == "")
            {
                continue; 
            }
            else if (arr2[i] == arr1[i])
            {
                score += 4; 
            }
            else
            {
                score -= 1; 
            }
        }

        return Math.Max(score, 0); 
    }
}
//7 kyu Money, Money, Money
public class Kata
{
    public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
    {
        int years = 0;

        while (principal < desiredPrincipal)
        {
            double yearlyInterest = principal * interest; 
            double taxedInterest = yearlyInterest * (1 - tax); 
            principal += taxedInterest; 
            years++;
        }

        return years;
    }
}
//7 kyu Sum of a sequence
public static class Kata
{
    public static int SequenceSum(int start, int end, int step)
    {
        if (start > end) return 0;

        int sum = 0;
        for (int i = start; i <= end; i += step)
        {
            sum += i;
        }

        return sum;
    }
}
//7 kyu Sort array by string length
public class Kata
{
    public static string[] SortByLength(string[] array)
{
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        return array;
    }
}
//7kyu Small enough? - Beginner
public class Kata
{
    public static bool SmallEnough(int[] a, int limit)
    {
        foreach (int num in a)
        {
            if (num > limit)
                return false;
        }
        return true;
    }
}
//7kyu Count the Digit
public class CountDig
{
    public static int NbDig(int n, int d)
    {
        int count = 0;
        char digit = d.ToString()[0]; 
        
        for (int k = 0; k <= n; k++)
        {
            string square = (k * k).ToString(); 
            foreach (char c in square)
            {
                if (c == digit)
                {
                    count++;
                }
            }
        }
        
        return count;
    }
}
//7kyu Breaking chocolate problem
public class Kata 
{
  public static int BreakChocolate(int n, int m) 
  {
   if (n <= 0 || m <= 0) return 0;
   return (n * m) - 1;
  }
}
//7kyu Mumbling
public class Accumul 
{
	public static String Accum(string s) 
  {
     return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
  }
}
//7kyu Friend or Foe?
public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        return names.Where(name => name.Length == 4);
    }
}
//7kyu Growth of a Population
class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
        int year;
        for (year = 0; p0 < p; year++)
          p0 += (int)(p0*percent/100) + aug;
        return year;
    }
}
//7kyu Changing letters
public static class Kata
{
    public static string Swap(string s)
    {
        string vowels = "aeiou";
        
        char[] result = s.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (vowels.Contains(char.ToLower(result[i])))
            {
                result[i] = char.ToUpper(result[i]);
            }
        }
        
        return new string(result);
    }
}
//7 kyu Are the numbers in order?
public class Kata
{
    public static bool IsAscOrder(int[] arr)
    {
        if (arr.Length <= 1)
            return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
                return false; 
        }

        return true; 
    }
}

class _7kyu
{
    static void Main()
    {
        BasicFixedTests();
        AdvancedFixedTests();
    }

    static void BasicFixedTests()
    {
        Console.WriteLine($"Test 1: {Kata.IsAscOrder(new int[] { 1, 2 }) == true}");
        Console.WriteLine($"Test 2: {Kata.IsAscOrder(new int[] { 2, 1 }) == false}");
        Console.WriteLine($"Test 3: {Kata.IsAscOrder(new int[] { 1, 2, 3 }) == true}");
        Console.WriteLine($"Test 4: {Kata.IsAscOrder(new int[] { 1, 3, 2 }) == false}");
        Console.WriteLine($"Test 5: {Kata.IsAscOrder(new int[] { 2, 1, 3 }) == false}");
        Console.WriteLine($"Test 6: {Kata.IsAscOrder(new int[] { 2, 3, 1 }) == false}");
        Console.WriteLine($"Test 7: {Kata.IsAscOrder(new int[] { 3, 1, 2 }) == false}");
        Console.WriteLine($"Test 8: {Kata.IsAscOrder(new int[] { 3, 2, 1 }) == false}");
    }

    static void AdvancedFixedTests()
    {
        Console.WriteLine($"Test 9: {Kata.IsAscOrder(new int[] { 1, 4, 13, 97, 508, 1047, 20058 }) == true}");
        Console.WriteLine($"Test 10: {Kata.IsAscOrder(new int[] { 56, 98, 123, 67, 742, 1024, 32, 90969 }) == false}");
    }
}
