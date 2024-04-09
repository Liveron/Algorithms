namespace Algorithms.Miscellaneous
{
    public static class BreakCamelCase
    {
        /// <summary>
        /// Breaks up camel casing, using a space between words
        /// </summary>
        /// <returns>
        /// String with spaces
        /// </returns>
        /// <param name="camelCaseStr"></param>
        public static string Invoke(string camelCaseStr)
        {
            string result = string.Empty;
            foreach (var item in camelCaseStr)
            {
                result += char.IsUpper(item) ? " " + item : item;
            }

            return result;
        }
    }
}
