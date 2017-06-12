using System;
using System.Linq;
using System.Text;

namespace Solution
{
    public static class TIY
    {
        public static string FizzBuzz(string sentence)
        {
            var vowels = "aeiouAEIOU";
            var ans = "";

            foreach (var item in sentence)
            {
                if (char.IsUpper(item) && vowels.Contains(item))
                {
                    ans += "Iron Yard";
                }
                if (char.IsUpper(item) && !vowels.Contains(item))
                {
                    ans += "Iron";
                }
                if ((char.IsLower(item) && !vowels.Contains(item)) || !char.IsLetter(item))
                {
                    ans += item;
                }
                if (char.IsLower(item) && vowels.Contains(item))
                {
                    ans += "Yard";
                }
            }
            return ans;
        }
    }
}