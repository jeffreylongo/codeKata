namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            var NoSpace = input;
            NoSpace = NoSpace.Replace(" ", "");
            return NoSpace;
        }
    }
}