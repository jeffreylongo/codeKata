public class Swapper
{
    public object[] Arguments { get; private set; }

    public Swapper(object[] args)
    {
        Arguments = args;
    }

    public void SwapValues()
    {
        Arguments = new[] { Arguments[0], Arguments[1] };

        object temp = Arguments[0];
        Arguments[0] = Arguments[1];
        Arguments[1] = temp;
    }
}