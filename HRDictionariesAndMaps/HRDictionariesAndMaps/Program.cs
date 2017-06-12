using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        var total = int.Parse(Console.ReadLine());
        var phonebook = new Dictionary<string, string>();
        for (int i = 0; i < total; i++)
        {
            var data = Console.ReadLine().Split(' ');
            phonebook.Add(data[0], data[1]);
        }

        var stillReading = true;
        var names = new List<string>();
        do
        {
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                stillReading = false;
            }
            else
            {
                names.Add(input);
            }
        } while (stillReading);

        foreach (var item in names)
        {
            if (phonebook.ContainsKey(item))
            {
                Console.WriteLine($"{item}={phonebook[item]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}