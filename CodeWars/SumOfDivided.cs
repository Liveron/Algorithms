using System.Text;

namespace Algorithms.CodeWars
{
    public class SumOfDivided
    {
        public static string Invoke(int[] numbers)
        {
            var primes = new List<int>();
            int max = numbers.Max(Math.Abs);

            for (int i = 0; i <= max; i++) 
            {
                primes.Add(i);
            }

            if (primes.Count >= 2)
                primes[1] = 0; 

            for (int i = 2; i <= max; i++)
            {
                if (primes[i] != 0)
                {
                    int j = i + i;
                    while (j <= max)
                    {
                        primes[j] = 0;
                        j += i;
                    }
                }
            }

            primes.RemoveAll(x => x == 0);

            return primes.Aggregate(new StringBuilder(), (acc, x) => acc.Append(numbers.Any(y => y % x == 0) ? 
                $"({x} {numbers.Where(z => z % x == 0).Sum()})" : string.Empty)).ToString();
        }
    }
}
