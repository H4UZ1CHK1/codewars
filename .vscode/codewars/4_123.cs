//1
using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        if (array.Length == 0 || array[0].Length == 0)
            return new int[0];

        var result = new List<int>();
        int n = array.Length;
        int top = 0, bottom = n - 1;
        int left = 0, right = n - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
                result.Add(array[top][i]);
            top++;

            for (int i = top; i <= bottom; i++)
                result.Add(array[i][right]);
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    result.Add(array[bottom][i]);
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result.Add(array[i][left]);
                left++;
            }
        }

        return result.ToArray();
    }
}
//2
using System;
using System.Collections.Generic;
using System.Linq;

public class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
            return "now";

        int years = seconds / (365 * 24 * 3600);
        seconds %= 365 * 24 * 3600;
        int days = seconds / (24 * 3600);
        seconds %= 24 * 3600;
        int hours = seconds / 3600;
        seconds %= 3600;
        int minutes = seconds / 60;
        seconds %= 60;

        var timeComponents = new List<string>();

        if (years > 0) timeComponents.Add($"{years} year{(years > 1 ? "s" : "")}");
        if (days > 0) timeComponents.Add($"{days} day{(days > 1 ? "s" : "")}");
        if (hours > 0) timeComponents.Add($"{hours} hour{(hours > 1 ? "s" : "")}");
        if (minutes > 0) timeComponents.Add($"{minutes} minute{(minutes > 1 ? "s" : "")}");
        if (seconds > 0) timeComponents.Add($"{seconds} second{(seconds > 1 ? "s" : "")}");

        return timeComponents.Count > 1
            ? string.Join(", ", timeComponents.Take(timeComponents.Count - 1)) + " and " + timeComponents.Last()
            : timeComponents.First();
    }
}
//3
using System;
using System.Collections.Generic;
using System.Linq;

public class Intervals
{
    public static int SumIntervals((int, int)[] intervals)
    {
        if (intervals.Length == 0)
            return 0;

        var sortedIntervals = intervals.OrderBy(interval => interval.Item1).ToList();
        var mergedIntervals = new List<(int, int)>();

        var current = sortedIntervals[0];
        
        foreach (var interval in sortedIntervals.Skip(1))
        {
            if (interval.Item1 <= current.Item2) 
                current = (current.Item1, Math.Max(current.Item2, interval.Item2));
            else
            {
                mergedIntervals.Add(current);
                current = interval;
            }
        }

        mergedIntervals.Add(current); 

        return mergedIntervals.Sum(interval => interval.Item2 - interval.Item1);
    }
}

