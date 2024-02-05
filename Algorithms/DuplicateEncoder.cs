using System.Text;

namespace Algorithms
{
    public static class DuplicateEncoder
    {
        public static string Invoke(string word)
        {
            string lower = word.ToLower();
            var counts = new Dictionary<char, int>();

            foreach (var character in lower)
            {
                if (counts.ContainsKey(character))
                    counts[character]++;
                else
                    counts.Add(character, 1);
            }

            var resultString = new StringBuilder();
            foreach (var character in lower)
            {
                if (counts[character] == 1)
                    resultString.Append('(');
                else
                    resultString.Append(')');
            }

            return resultString.ToString();
        }
    }
}
