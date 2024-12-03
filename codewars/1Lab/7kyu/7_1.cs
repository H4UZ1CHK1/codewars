using System;

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