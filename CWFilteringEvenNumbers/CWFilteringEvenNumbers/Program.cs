using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] % 2 == 0)
            {
                listOfNumbers.RemoveAt(i--);
            }
        }
        return listOfNumbers;
    }
}