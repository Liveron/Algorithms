namespace Algorithms.CodeWars
{
    public static class RomanNumeralDecoder
    {
        static readonly Dictionary<char, int> _romanDecimal = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        /// <summary>
        /// Method that takes a Roman numeral
        /// as its argument and returns its value
        /// as a numeric decimal integer. Doesn't
        /// validate the form of the Roman numeral.
        /// </summary>
        /// <param name="roman"></param>
        /// <returns>int</returns>
        public static int Decode(string roman)
        {
            int result = 0, max = 0;

            foreach (char c in roman.Reverse())
            {
                int value = _romanDecimal[c];

                if (value < max)
                    result -= value;
                
                else
                {
                    result += value;
                    max = value;
                }
            }

            return result;
        }
    }
}
