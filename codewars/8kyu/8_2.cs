using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    int availableSpace = cap - on;
    return (availableSpace >= wait) ? 0 : wait - availableSpace;
  }
}