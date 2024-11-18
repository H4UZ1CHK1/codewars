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