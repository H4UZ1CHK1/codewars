using System;
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