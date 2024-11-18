using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata{
//7kyu Changing letters
/*public static class Kata
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
/*                             `-:/+++++++/++:-.                                          
                            .odNMMMMMMMMMMMMMNmdo-`                                      
                           +mMMNmdhhhhhhhhhdmNMMMNd/`                                    
                          sMMMmhyyyyyyyyyyyyyyhmNMMMh-                                   
                         +MMMdyyyyyyyhhhhdddddddmMMMMN/                                  
                        `NMMmyyyyyymNNMMNNNmmmmmmmNNMMMy`                                
                        :MMMhyyyyyNMMMho+//:-.....-:omMMd-                               
                    ```:mMMNhyyyyhMMMh+::::-        `:sNMN:                              
                 -oyhdmMMMMmhyyyyhMMNyy+::::---------::yMMm                              
                +MMMMNNNMMMdhyyyyhMMNyyyso/::::::://+oshMMM`                             
                NMMNhyyyMMMhhyyyyyNMMmyyyyyyssssyyyyyyymMMd                              
                MMMdyyyhMMNhhyyyyyhNMMNdyyyyyyyyyyyhdmMMMN-                              
                MMMdhhhdMMNhhhyyyyyymMMMMNmmmmmmNNMMMMMMN.                               
                MMMhhhhdMMNhhhyyyyyyyhdmNNNMMNNNmmdhhdMMd                                
               `MMMhhhhdMMNhhhhyyyyyyyyyyyyyyyyyyyyyydMMM.                               
               .MMMhhhhdMMNhhhhyyyyyyyyyyyyyyyyyyyyyydMMM:                               
               .MMNhhhhdMMNhhhhhyyyyyyyyyyyyyyyyyyyyhhMMM+                               
               -MMNhhhhdMMNhhhhhyyyyyyyyyyyyyyyyyyyyhdMMM/                               
               -MMMhhhhdMMNhhhhhhhyyyyyyyyyyyyyyyyyhhdMMM-                               
               `MMMhhhhhMMNhhhhhhhhhhyyyyyyyyyyyhhhhhmMMN                                
                hMMmhhhhMMNhhhhhhhhhhhhhhhhhhhhhhhhhhNMMy                                
                :MMMNmddMMMhhhhhhhhhhddddhhhhhhhhhhhdMMM/                                
                 :hNMMMMMMMdhhhhhhhhdMMMMMMNNNNNdhhhNMMN`                                
                   .-/+oMMMmhhhhhhhhmMMmyhMMMddhhhhdMMMy                                 
                        hMMNhhhhhhhhmMMd :MMMhhhhhhdMMM+                                 
                        sMMNhhhhhhhhNMMm .MMMdhhhhhdMMN.                                 
                        /MMMdhhhhhhdMMM+  oNMMNNNNNMMm:                                  
                        `dMMMNmmmNNMMMh`   -syyyyhhy/`                                   
                         `/hmNNNNNmdh/`                                                  
                            `.---..`
*/
//7kyu Growth of a Population
/*class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
        int year;
        for (year = 0; p0 < p; year++)
          p0 += (int)(p0*percent/100) + aug;
        return year;
    }
}
//6kyu Detect Pangram
public static class Kata
{
  public static bool IsPangram(string str)
  {
    return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
  }
}
//6kyu Replace With Alphabet Position
public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        return string.Join(" ", text
            .ToLower()
            .Where(char.IsLetter)
            .Select(c => c - 'a' + 1)); 
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
//7kyu Mumbling
public class Accumul 
{
	public static String Accum(string s) 
  {
     return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
  }
}
//4kyu Adding Big Numbers
public class Kata
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
}
//4kyu Catching Car Mileage Numbers
public static class Kata
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
}
//4kyu Sum Strings as Numbers
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      BigInteger aInt;
      BigInteger bInt;
      
      BigInteger.TryParse(a, out aInt);
      BigInteger.TryParse(b, out bInt);
      
      return (aInt + bInt).ToString();
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
//8kyu get character from ASCII Value
public class Kata
{
    public static char GetChar(int charcode)
    {
        return (char)charcode;
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
//8kyu My head is at the wrong end!
public class Kata
{
  public static string[] FixTheMeerkat(string[] arr)
  {
    return new string[] { arr[2], arr[1], arr[0] };
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
//5kyu Not very secure
public class Kata
{
    public static bool Alphanumeric(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        foreach (char c in str)
        {
            if (!char.IsLetterOrDigit(c))
                return false;
        }

        return true;
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
//8kyu Sort and Star
public class Kata
{
    public static string TwoSort(string[] s)
    {
        Array.Sort(s, StringComparer.Ordinal);
        return string.Join("***", s[0].ToCharArray());
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
//7 kyu Sort array by string length
public class Kata
{
    public static string[] SortByLength(string[] array)
{
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        return array;
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
//8 kyu Find the position!
public class Kata
{
    public static string Position(char alphabet)
    {
        return $"Position of alphabet: {alphabet - 'a' + 1}";
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

//4 kyu Pyramid Slide Down
public class PyramidSlideDown
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
}
//8 kyu Vowel remover
public class Kata
{
    public static string Shortcut(string input)
    {
        return string.Concat(input.Where(c => !"aeiou".Contains(c)));
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
//8 kyu Grasshopper - Messi Goals
public static class Kata 
{
    public static int la_liga_goals = 43;
    public static int champions_league_goals = 10;
    public static int copa_del_rey_goals = 5;
    public static int total_goals = la_liga_goals + champions_league_goals + copa_del_rey_goals;
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
//7 kyu Check the exam*/
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
    public static void Main(string[] args){

    }
}}