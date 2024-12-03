using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//8 kyu Dollars and Cents
public class Kata
{
    public static string FormatMoney(double amount) => $"${amount:F2}";
}
//8 kyu Formatting decimal places #0
public class Numbers
{
  public static double TwoDecimalPlaces(double number)
  {
    return Math.Round(number, 2, MidpointRounding.AwayFromZero);
  }
}
//8 kyu 101 Dalmatians - squash the bugs, not the dogs!
public static class Kata
{
    public static string HowManyDalmatians(int n)
    {
        List<string> dogs = new List<string>()
        {
            "Hardly any",
            "More than a handful!",
            "Woah that's a lot of dogs!",
            "101 DALMATIONS!!!" 
        };

        string respond = n <= 10 ? dogs[0] : n <= 50 ? dogs[1] : n == 101 ? dogs[3] : dogs[2];

        return respond;
    }
}
//8 kyu Is this my tail?
public class Kata
{
    public static bool CorrectTail(string body, string tail)
    {
        Func<string, string, bool> checkTail = (b, t) =>
        {
            return b.EndsWith(t);
        };

        return checkTail(body, tail);
    }
}
//8 kyu Gravity Flip
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {
        return dir == 'R' ? arr.OrderBy(x => x).ToArray() : arr.OrderByDescending(x => x).ToArray();
    }
}
//8 kyu Convert number to reversed array of digits
namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Reverse().Select(c => (long)char.GetNumericValue(c)).ToArray();
        }
    }
}
//8 kyu To square(root) or not to square(root)
public class Kata
{
    public static int[] SquareOrSquareRoot(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int sqrt = (int)Math.Sqrt(array[i]);
            array[i] = (sqrt * sqrt == array[i]) ? sqrt : array[i] * array[i];
        }
        return array;
    }
}
//8 kyu Filter out the geese
public static class Filter
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
        return birds.Where(bird => !geese.Contains(bird));
    }
}
//8 kyu Bin to Decimal
namespace Solution
{
    public static class Program
    {
        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }
    }
}
//8 kyu FIXME: Replace all dots
public class Kata
{
  public static string ReplaceDots(string str)
  {
    return Regex.Replace(str, @"\.", "-");
  }
}
//8 kyu Keep Hydrated!
public class Kata
{
  public static int Litres(double time)
  {
    return (int)Math.Floor(time * 2 / 4);
  }
}
//8 kyu Pillars
public static class Kata
{
    public static int Pillars(int numPill, int dist, int width)
    {
        return numPill == 1 ? 0 : Enumerable.Repeat(dist * 100, numPill - 1).Sum() + (width * (numPill - 2));
    }
}
//8 kyu Grasshopper - Terminal game move function
public class Game
{
  public static int Move(int position, int roll) 
  {
  	return position + roll * 2;
  }
}
//8 kyu Area and Volume of a Box
public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        int area = 2 * (w * h + h * d + w * d);

        int volume = w * h * d;

        return new int[] { area, volume };
    }
}
//8 kyu Simple Fun #1: Seats in Theater
public class Kata
{
    public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
        int rowsBehind = nRows - row;

        int colsLeft = nCols - col + 1;

        return rowsBehind * colsLeft;
    }
}
//8 kyu Get Nth Even Number
public class Kata
{
  public static int NthEven(int n)
  {
    return 2 * (n - 1);
  }
}
//8 kyu Reversing Words in a String
public class Kata
{
    public static string Reverse(string text)
    {
        string[] words = text.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
//8 kyu Grasshopper - Debug sayHello
public class Kata
{
  public static string SayHello(string name)
  {
    return $"Hello, {name}";
  }
}
//8 kyu Difference of Volumes of Cuboids
public class Kata
{
  public static int FindDifference(int[] a, int[] b)
  {
    return Math.Abs(a.Aggregate((x, y) => x * y) - b.Aggregate((x, y) => x * y));
  }
}
//8 kyu Grasshopper - If/else syntax debug
public class Player
{
    private int health = 100;

    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            health = value;
        }
    }

    public Player()
    {
    }

    public bool CheckAlive()
    {
        if (this.Health <= 0) 
        {
            return false; 
        }
        else
        {
            return true;
        }
    }
}
//8 kyu How many lightsabers do you own?
public class Kata
{
    public static int HowManyLightsabersDoYouOwn(string name = "")
    {
        return name == "Zach" ? 18 : 0;
    }
}
//8 kyu Find Multiples of a Number
public class Kata
{
    public static List<int> FindMultiples(int integer, int limit)
    {
        List<int> multiples = new List<int>();

        for (int i = integer; i <= limit; i += integer)
        {
            multiples.Add(i);
        }

        return multiples;
    }
}
//8 kyu Grasshopper - Messi Goals
public static class Kata 
{
    public static int la_liga_goals = 43;
    public static int champions_league_goals = 10;
    public static int copa_del_rey_goals = 5;
    public static int total_goals = la_liga_goals + champions_league_goals + copa_del_rey_goals;
}
//8 kyu Vowel remover
public class Kata
{
    public static string Shortcut(string input)
    {
        return string.Concat(input.Where(c => !"aeiou".Contains(c)));
    }
}
//8 kyu Find the position!
public class Kata
{
    public static string Position(char alphabet)
    {
        return $"Position of alphabet: {alphabet - 'a' + 1}";
    }
}
//8 kyu Exclamation marks series #1: Remove an exclamation mark from the end of string
public class Kata
{
    public static string Remove(string s)
    {
        return s.EndsWith("!") ? s.Substring(0, s.Length - 1) : s;
    }
}
//8kyu Holiday VIII - Duty Free
public class Kata
{
    public static int DutyFree(int normPrice, int Discount, int hol)
    {
        double savingsPerBottle = normPrice * (Discount / 100.0);
        return (int)(hol / savingsPerBottle);
    }
}
//8kyu Sort and Star
public class Kata
{
    public static string TwoSort(string[] s)
    {
        Array.Sort(s, StringComparer.Ordinal);
        return string.Join("***", s[0].ToCharArray());
    }
}
//8kyu Count of positives / sum of negatives
public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length == 0)
            return new int[0];

        int positiveCount = 0;
        int negativeSum = 0;

        foreach (int number in input)
        {
            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeSum += number;
            }
        }

        return new int[] { positiveCount, negativeSum };
    }
}
//8kyu My head is at the wrong end!
public class Kata
{
  public static string[] FixTheMeerkat(string[] arr)
  {
    return new string[] { arr[2], arr[1], arr[0] };
  }
}
//8kyu Drink about
public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    if (old < 14)
    {
      return "drink toddy";
    }
    else if (old < 18)
    {
      return "drink coke";
    }
    else if (old < 21)
    {
      return "drink beer";
    }
    else
    {
      return "drink whisky";
    }
  }
}
//8kyu Unfinished Loop - Bug Fixing #1
public class Kata
{
  public static List<int> CreateList(int number)
  {
    List<int> list = new List<int>();
    
    for (int counter = 1; counter <= number; counter++) 
    {
      list.Add(counter);
    }
    
    return list;
  }
}
//8kyu get character from ASCII Value
public class Kata
{
    public static char GetChar(int charcode)
    {
        return (char)charcode;
    }
}
//8kyu Count by X
public static class Kata
{
  public static int[] CountBy(int x, int n)
  {
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
      result[i] = x * (i + 1);
    }
    return result;
  }
}
//8 kyu Take the Derivative
public class Kata
{
    public static string Derive(double coefficient, double exponent)
    {
        double newCoefficient = coefficient * exponent;
        double newExponent = exponent - 1;

        return $"{newCoefficient}x^{newExponent}";
    }
}

class _8kyu
{
    static void Main()
    {
        BasicTests();
    }

    static void BasicTests()
    {
        Console.WriteLine(Kata.Position('a') == "Position of alphabet: 1");
        Console.WriteLine(Kata.Position('z') == "Position of alphabet: 26");
        Console.WriteLine(Kata.Position('e') == "Position of alphabet: 5");
    }
}
