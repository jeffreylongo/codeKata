using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dinglemouse
{
    private string firstName;
    private string lastName;
    public string FullName
    {
        get
        {
            return (firstName + " " + lastName).Trim();
        }
    }

    public Dinglemouse(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
