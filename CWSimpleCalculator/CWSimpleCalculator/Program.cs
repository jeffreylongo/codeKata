public class Kata
{
    public static double Calculator(double a, double b, char op)
    {
        if (op == '+')
        {
            return a + b;
        }
        else if (op == '-')
        {
            return a - b;
        }
        else if (op == '*')
        {
            return a * b;
        }
        else if (op == '/')
        {
            return a / b;
        }
        else
        {
            throw new System.ArgumentException("unknown value");
        }
    }
}
