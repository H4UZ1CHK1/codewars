using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//5 kyu Land perimeter
/*public class LandPerimeter
{
    public static string Calculate(string[] map)
    {
        int perimeter = 0;

        for (int i = 0; i < map.Length; i++)
        {
            for (int j = 0; j < map[i].Length; j++)
            {
                if (map[i][j] == 'X')
                {
                    if (i == 0 || map[i - 1][j] == 'O') perimeter++;
                    if (i == map.Length - 1 || map[i + 1][j] == 'O') perimeter++;
                    if (j == 0 || map[i][j - 1] == 'O') perimeter++;
                    if (j == map[i].Length - 1 || map[i][j + 1] == 'O') perimeter++;
                }
            }
        }

        return $"Total land perimeter: {perimeter}";
    }
}*/
//5 kyu Can you get the loop ?
/*public class Kata
{
    public static int getLoopSize(LoopDetector.Node startNode)
    {
        Dictionary<LoopDetector.Node, int> visitedNodes = new Dictionary<LoopDetector.Node, int>();

        int index = 0;
        LoopDetector.Node currentNode = startNode;

        while (currentNode != null)
        {
            if (visitedNodes.ContainsKey(currentNode))
            {
                return index - visitedNodes[currentNode];
            }

            visitedNodes[currentNode] = index;
            index++;
            currentNode = currentNode.next;
        }

        return 0;
    }
}*/
//5 kyu Count IP Addresses
/*public class CountIPAddresses
{
    public static long IpsBetween(string start, string end)
    {
        long IpToLong(string ip)
        {
            string[] parts = ip.Split('.');
            return (long.Parse(parts[0]) << 24) + (long.Parse(parts[1]) << 16) + 
                   (long.Parse(parts[2]) << 8) + long.Parse(parts[3]);
        }

        return IpToLong(end) - IpToLong(start);
    }
}*/
//5 kyu Pick peaks
/*public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        var result = new Dictionary<string, List<int>>
        {
            { "pos", new List<int>() },
            { "peaks", new List<int>() }
        };

        if (arr.Length < 3) return result;

        int potentialPeakPos = -1; 

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] >= arr[i + 1])
            {
                potentialPeakPos = i;
            }

            if (potentialPeakPos != -1 && arr[i] > arr[i + 1])
            {
                result["pos"].Add(potentialPeakPos);
                result["peaks"].Add(arr[potentialPeakPos]);
                potentialPeakPos = -1;
            }
        }

        return result;
    }
}*/
//5 kyu Perimeter of squares in a rectangle
/*public class SumFct
{
    public static BigInteger perimeter(BigInteger n)
    {
        BigInteger a = 1, b = 1;
        BigInteger sum = a + b;

        for (int i = 2; i <= n; i++)
        {
            BigInteger next = a + b;
            sum += next;
            a = b; 
            b = next;
        }

        return 4 * sum;
    }
}*/
//5kyu Not very secure
/*public class Kata
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
}*/
//5 kyu Integers: Recreation One
public class SumSquaredDivisors 
{
    public static string listSquared(long m, long n)
    {
        var result = new List<string>();
        
        for (long i = m; i <= n; i++)
        {
            long sumOfSquares = SumOfSquaredDivisors(i);

            if (IsPerfectSquare(sumOfSquares))
            {
                result.Add($"[{i}, {sumOfSquares}]");
            }
        }

        return "[" + string.Join(", ", result) + "]";
    }

    private static long SumOfSquaredDivisors(long number)
    {
        long sum = 0;

        for (long i = 1; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                sum += i * i;
                
                if (i != number / i) 
                {
                    sum += (number / i) * (number / i);
                }
            }
        }

        return sum;
    }

    private static bool IsPerfectSquare(long num)
    {
        long sqrt = (long)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}

class _5kyu
{
    static void Main()
    {
        Test01();
        Test02();
        Test03();
    }

    static void Test01()
    {
        if (SumSquaredDivisors.listSquared(1, 250) == "[[1, 1], [42, 2500], [246, 84100]]")
            Console.WriteLine("Test01 Passed");
        else
            Console.WriteLine("Test01 Failed");
    }

    static void Test02()
    {
        if (SumSquaredDivisors.listSquared(42, 250) == "[[42, 2500], [246, 84100]]")
            Console.WriteLine("Test02 Passed");
        else
            Console.WriteLine("Test02 Failed");
    }

    static void Test03()
    {
        if (SumSquaredDivisors.listSquared(250, 500) == "[[287, 84100]]")
            Console.WriteLine("Test03 Passed");
        else
            Console.WriteLine("Test03 Failed");
    }
}
