using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {

        var oCount = input.ToLower().Where(o => o == 'x').Count();
        var xCount = input.ToLower().Where(x => x == 'o').Count();


        if (oCount == xCount)
        {
            return true;
        }
        else if (oCount != xCount)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}