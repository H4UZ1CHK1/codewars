using System;
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    foreach (int number in numbers)
    {
      sum += number * number;
    }
    return sum;
  }
}
