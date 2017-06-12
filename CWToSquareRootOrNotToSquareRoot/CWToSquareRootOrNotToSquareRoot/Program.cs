using System;
using System.Collections.Generic;

public class Kata
{
    public static int[] SquareOrSquareRoot(int[] array)
    {
        var rv = new List<int>();
        foreach (var number in array)
        {
            if (Math.Sqrt(number) == (int)Math.Sqrt(number))
            {
                rv.Add((int)Math.Sqrt(number));

            }
            else
            {
                rv.Add(number * number);

            }
        }
        return rv.ToArray();
    }
}