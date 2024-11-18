using System;
using System.Collections.Generic;

public static class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        var result = new List<object>();

        for (int i = 0; i < arr.Length; i += 2)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }
}