using System.Text;

namespace Algorithms.CodeWars
{
    public class Rot13
    {
        public static string Invoke(string message)
        {
            var encrypted = new StringBuilder();

            foreach (char c in message)
            {
                if ((c >= 'a' && c <= 'm') || (c >= 'A' && c <= 'M'))
                    encrypted.Append(Convert.ToChar(c + 13));
                else if ((c >= 'n' && c <= 'z') || (c >= 'N' && c <= 'Z'))
                    encrypted.Append(Convert.ToChar(c - 13));
                else encrypted.Append(c);
            }

            return encrypted.ToString();
        }
    }
}
