using System;

public class Number
{
    public static int DigitalRoot(long n)
    {
        while (n >= 10)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }
        return (int)n;
    }
}
