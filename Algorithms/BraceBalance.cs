namespace Algorithms;

public static class BraceBalance
{
    private static readonly Dictionary<char, char> _pairs = new()
    {
        {'{', '}'},
        {'(', ')'},
        {'[', ']'},
    };

    public static bool Invoke(string text)
    {
        if (text is null) return false;

        var stack = new Stack<char>();
        foreach (var symbol in text)
        {
            if (_pairs.ContainsKey(symbol))
                stack.Push(symbol);

            else if (!_pairs.ContainsValue(symbol)) continue;
            else if (stack.Count == 0) return false;
            else if (_pairs[stack.Pop()] != symbol) return false;
        }

        return stack.Count == 0;
    }
}