using System.Text;

namespace Algorithms.Miscellaneous
{
    public static class BreakCamelCase
    {
        /// <summary>
        /// Breaks up camel casing, using a space between words
        /// </summary>
        /// <returns>
        /// String with spaces between words
        /// </returns>
        /// <param name="camelCaseStr">String in camel case</param>
        public static string Invoke(string camelCaseStr)
        {
            var result = new StringBuilder();

            foreach (var item in camelCaseStr)
            {
                result.Append(char.IsUpper(item) ? " " + item : item);
            }

            return result.ToString();
        }
    }
}
