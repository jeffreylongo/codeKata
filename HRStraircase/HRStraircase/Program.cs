using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int e = 0; e < n - i; e++)
            {
                Console.Write(" ");
            }
            for (int v = 0; v < i; v++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}