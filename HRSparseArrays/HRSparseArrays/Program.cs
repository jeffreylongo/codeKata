using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        // Inputs
        var N = int.Parse(Console.ReadLine());
        var dataset = new List<string>();
        for (int i = 0; i < N; i++)
        {
            dataset.Add(Console.ReadLine());
        }
        var Q = int.Parse(Console.ReadLine());
        var queries = new List<string>();
        for (int i = 0; i < Q; i++)
        {
            queries.Add(Console.ReadLine());
        }

        var answers = new List<int>();

        answers = queries.Select(query => dataset.Count(dataItem => query == dataItem)).ToList();

        answers.ForEach(i => Console.WriteLine(i));
    }
}