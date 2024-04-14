namespace Algorithms.Miscellaneous
{
    public static class DirectionReducer
    {
        static readonly Dictionary<string, string> opposites = new() 
        { 
            ["WEST"] = "EAST",
            ["EAST"] = "WEST",
            ["NORTH"] = "SOUTH",
            ["SOUTH"] = "NORTH",
        };

        public static string[] Invoke(string[] directions)
        {
            if (directions.Length <= 1)
            {
                return directions;
            }

            var stack = new Stack<string>();

            foreach (string curDir in directions)
            {
                if (stack.Count != 0)
                {
                    if (opposites[curDir] == stack.Peek())
                    {
                        stack.Pop();
                        continue;
                    }
                }

                stack.Push(curDir);
            }
           
            return [.. stack.Reverse()];
        }
    }
}
