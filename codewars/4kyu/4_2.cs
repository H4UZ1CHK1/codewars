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