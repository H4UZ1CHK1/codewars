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
