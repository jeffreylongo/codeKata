using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        var A = 0;
        var B = 0;
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        if (a0 > b0)
        {
            A += 1;
        }
        if (a0 < b0)
        {
            B += 1;
        }
        if (a1 > b1)
        {
            A += 1;
        }
        if (a1 < b1)
        {
            B += 1;
        }
        if (a2 > b2)
        {
            A += 1;
        }
        if (a2 < b2)
        {
            B += 1;
        }

        Console.WriteLine($"{A} {B}");

    }
}