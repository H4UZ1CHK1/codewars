//1
public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    double[] result = new double[m];
    for (int i = 0; i < m; i++)
    {
      result[i] = n * (i + 1);
    }
    return result;
  }
}
//2
using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        return Regex.Replace(str, "[aeiouAEIOU]", "");
    }
}
//3
using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string result = "";
    
    foreach (char digit in n.ToString())
    {
      int square = (int)char.GetNumericValue(digit) * (int)char.GetNumericValue(digit);
      result += square.ToString();
    }
    
    return int.Parse(result);
  }
}
