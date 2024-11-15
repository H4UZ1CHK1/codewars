//1
using System.Collections.Generic;

public static class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        var result = new List<object>();

        for (int i = 0; i < arr.Length; i += 2)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }
}
//2
using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    int availableSpace = cap - on;
    return (availableSpace >= wait) ? 0 : wait - availableSpace;
  }
}
//3
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
