//4_1
using System;
using System.Collections.Generic;

class Program
{
    public static List<int> Snail(int[][] array)
    {
        List<int> result = new List<int>();
        while (array.Length > 0)
        {
            result.AddRange(array[0]);
            array = array[1..];

            for (int i = 0; i < array.Length; i++)
            {
                result.Add(array[i][^1]);
                array[i] = array[i][0..^1];
            }

            if (array.Length > 0)
            {
                result.AddRange(array[^1].Reverse());
                array = array[0..^1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result.Add(array[i][0]);
                array[i] = array[i][1..];
            }
        }
        return result;
    }
}
//4_2
using System;
using System.Collections.Generic;

class Program
{
    public static string FormatDuration(int seconds)
    {
        if (seconds == 0) return "now";

        var timeUnits = new List<(string unit, int value)>
        {
            ("year", 365 * 24 * 3600),
            ("day", 24 * 3600),
            ("hour", 3600),
            ("minute", 60),
            ("second", 1)
        };

        var result = new List<string>();

        foreach (var (unit, value) in timeUnits)
        {
            int amount = seconds / value;
            if (amount > 0)
            {
                result.Add($"{amount} {unit}{(amount > 1 ? "s" : "")}");
                seconds -= amount * value;
            }
        }

        return result.Count > 1
            ? string.Join(", ", result.GetRange(0, result.Count - 1)) + " and " + result[^1]
            : result[0];
    }
}
//4_3
using System;
using System.Collections.Generic;

class Program
{
    public static int SumIntervals(List<(int start, int end)> intervals)
    {
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        int totalLength = 0;
        int? currentStart = null;
        int? currentEnd = null;

        foreach (var (start, end) in intervals)
        {
            if (currentEnd == null || start > currentEnd)
            {
                if (currentEnd != null)
                {
                    totalLength += currentEnd.Value - currentStart.Value;
                }
                currentStart = start;
                currentEnd = end;
            }
            else
            {
                currentEnd = Math.Max(currentEnd.Value, end);
            }
        }

        if (currentEnd != null)
        {
            totalLength += currentEnd.Value - currentStart.Value;
        }

        return totalLength;
    }
}
