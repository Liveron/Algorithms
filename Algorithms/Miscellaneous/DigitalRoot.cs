namespace Algorithms.Miscellaneous
{
    public static class DigitalRoot
    {
        public static int Invoke(long n)
        {
            if (n == 0) return 0;
            if (n % 9 == 0) return 9;
            return (int)(n % 9);
        }
    }
}
