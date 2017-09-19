using System;

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        Int64 numbas = Convert.ToInt64(string.Join("", numbers));
        return numbas.ToString("(000) 000-0000");
    }
}
