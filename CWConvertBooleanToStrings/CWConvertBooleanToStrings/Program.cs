using System;
using System.Linq;

public class Kata
{
    bool word = false;
    public static string boolToWord(bool word)
    {
        if (word == true)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}