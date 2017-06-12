using System;

namespace Solution
{
    public class SolutionClass
    {
        int number = Convert.ToInt32(Console.ReadLine());
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}