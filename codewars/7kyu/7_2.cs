using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        return Regex.Replace(str, "[aeiouAEIOU]", "");
    }
}