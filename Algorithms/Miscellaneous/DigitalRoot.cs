namespace Algorithms.Miscellaneous
{
    public static class DigitalRoot
    {
        /// <summary>
        /// Calculates recursive sum of all the digits in a number by aggregation
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int InvokeWithAggregation(long n)
        {
            return n / 10 == 0 ? (int)n : InvokeWithAggregation(n.ToString().Aggregate(0, (acc, x) => acc + (int)char.GetNumericValue(x)));
        }

        public static int Invoke(long n)
        {
            if (n == 0) return 0;
            if (n % 9 == 0) return 9;
            return (int)(n % 9);
        }
    }
}
