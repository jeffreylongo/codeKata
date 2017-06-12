using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        bool newS = s.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
        if (newS)
        {
            Console.WriteLine(("pangram"));
        }
        else
        {
            Console.WriteLine("not pangram");
        }
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    }
};