using System;
using System.Linq;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1)
        {
            return 0;
        }
        Array.Sort(numbers);
        numbers[0] = 0;
        numbers[numbers.Length - 1] = 0;
        var sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}