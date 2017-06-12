using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string time = Console.ReadLine();
        List<string> timeList = time.Split(':').ToList();
        var splitted = time.Split(':');
        var mins = splitted[1];
        var seconds = splitted[2].Substring(0, 2);
        var hours = int.Parse(splitted[0]);

        if (time.Contains("PM") && hours != 12)
        {
            hours += 12;
        }
        if (time.Contains("AM") && hours == 12)
        {
            hours = 0;
        }


        Console.WriteLine($"{hours:00}:{ mins:00}:{ seconds:00}");
    }
}