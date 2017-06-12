using System;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        var newString = String.Empty;
        for (int i = 0; i < phrase.Length; i++)
        {
            var currentChar = phrase[i];
            if ((i > 0 && phrase[i - 1] == ' ') || i == 0)
            {
                currentChar = char.Parse(phrase[i].ToString().ToUpper());
            }
            newString += currentChar;

        }
        return newString;
    }
}