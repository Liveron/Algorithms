namespace Algorithms.CodeWars;

public class Intervals
{
    public static int SumIntervals((int, int)[] intervals)
    {
        if (intervals.Length == 0) return 0;

        var orderedIntervals = intervals.OrderBy(x => x.Item1);

        int intervalsSum = 0;

        int start = int.MinValue;
        int end = int.MinValue;

        foreach ((int, int) interval in orderedIntervals)
        {
            if (interval.Item1 <= end && interval.Item2 > end)
            {
                intervalsSum += interval.Item2 - end;
                start = interval.Item1;
                end = interval.Item2;
                continue;
            }
            if (interval.Item1 > end)
            {
                start = interval.Item1;
                end = interval.Item2;
                intervalsSum += end - start;
                continue;
            }
        }

        return intervalsSum;
    }
}
