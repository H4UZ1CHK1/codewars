//1
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

//2
function expandedForm(num) {
    let [integerPart, fractionalPart] = String(num).split('.');
  
    let result = [];
  
    for (let i = 0; i < integerPart.length; i++) {
      let digit = integerPart[i];
      if (digit !== '0') {
        result.push(digit + '0'.repeat(integerPart.length - i - 1));
      }
    }
  
    if (fractionalPart) {
      for (let i = 0; i < fractionalPart.length; i++) {
        let digit = fractionalPart[i];
        if (digit !== '0') {
          result.push(digit + '/' + Math.pow(10, i + 1));
        }
      }
    }
  
    return result.join(' + ');
  }
//3
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
