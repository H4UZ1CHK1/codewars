using System;
using System.Text;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
        StringBuilder result = new StringBuilder();
        string numberStr = num.ToString();
        int length = numberStr.Length;

        for (int i = 0; i < length; i++)
        {
            int digit = int.Parse(numberStr[i].ToString());

            if (digit != 0)
            {
                result.Append(digit * (long)Math.Pow(10, length - i - 1));

                if (i < length - 1)
                {
                    bool hasMoreNonZero = false;
                    for (int j = i + 1; j < length; j++)
                    {
                        if (numberStr[j] != '0')
                        {
                            hasMoreNonZero = true;
                            break;
                        }
                    }
                    
                    if (hasMoreNonZero)
                        result.Append(" + ");
                }
            }
        }

        return result.ToString();
    }
}