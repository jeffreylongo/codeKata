using System;

public static class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        var final = 0;
        if (bonus)
        {
            final = salary * 10;
        }
        else
        {
            final = salary;
        }
        return ("$" + final);
    }
    public static string bonus_time2(int salary, bool bonus) => "$" + (bonus ? salary * 10 : salary);
}
