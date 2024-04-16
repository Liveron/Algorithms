namespace Algorithms.Common.Numeric
{
    public static class SieveOfEratosyhenes
    {
        public static List<int> Invoke(int n)
        {
            var primes = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                primes.Add(i);
            }

            primes[1] = 0;

            for (int i = 2; i <= n; i++)
            {
                if (primes[i] != 0)
                {
                    int j = i + i;
                    while (j <= n)
                    {
                        primes[j] = 0;
                        j += i;
                    }
                }
            }

            return primes.Where(x => x != 0).ToList();
        }
    }
}
