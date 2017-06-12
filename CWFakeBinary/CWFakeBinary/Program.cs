using System;

public class Kata
{
    public static string FakeBin(string x)
    {
        var rv = String.Empty;
        //we are looping
        for (int i = 0; i < x.Length; i++)
        {
            if (int.Parse(x[i].ToString()) >= 5)
            {
                //do something
                rv += "1";
            }
            else
            {
                //do something else
                rv += "0";
            }
        }
        return rv;
    }
}