//8_1
using System;
using System.Collections.Generic;

class Program
{
    public static List<T> RemoveEveryOther<T>(List<T> array)
    {
        List<T> result = new List<T>();

        for (int i = 0; i < array.Count; i += 2)
        {
            result.Add(array[i]);
        }

        return result;
    }
}

//8_2
using System;

class Program
{
    public static int Enough(int cap, int on, int wait)
    {
        int availableSpace = cap - on;

        return availableSpace >= wait ? 0 : wait - availableSpace;
    }
}

//8_3
using System;
using System.Collections.Generic;

class Program
{
    public static int SquareSum(List<int> numbers)
    {
        int sum = 0;
        
        foreach (int num in numbers)
        {
            sum += num * num;
        }
        
        return sum;
    }
}
