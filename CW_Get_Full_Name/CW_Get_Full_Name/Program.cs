using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dinglemouse
{
    public static string firstName;
    public static string lastName;
    public string FullName
    {
        get
        {
            if (firstName == "")
            {
                firstName = String.Empty;
                return lastName;
            }
            if (lastName == "")
            {
                lastName = String.Empty;
                return firstName;
            }
            if (firstName == "" && lastName == "")
            {
                return String.Empty;
            }
            return firstName + " " + lastName;
        }
        set
        {
            
        }
    }

    public Dinglemouse(string firstName, string lastName)
    {
        Dinglemouse.firstName = firstName;
        Dinglemouse.lastName = lastName;
    }
}
