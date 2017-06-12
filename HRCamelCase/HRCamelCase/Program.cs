using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        Console.WriteLine((Console.ReadLine().Count(i => char.IsUpper(i)) + 1));

    }
}