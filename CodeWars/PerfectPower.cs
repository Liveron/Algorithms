namespace Algorithms.CodeWars
{
    public static class PerfectPower
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            int border = (int)Math.Sqrt(n);
            for (int i = 2; i <= border; border--)
            {
                int deg = Convert.ToInt32(Math.Log(n, border));
                if (Math.Pow(border, deg) == n)
                {
                    return (border, deg);
                }
            }

            return null;
        }
    }
}
