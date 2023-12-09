namespace Algorithms;

public static class QuickSort
{
    public static int[] Invoke(int[] array)
    {
        if (array.Length < 2) return array;
        else
        {
            int pivot = array[0];
            int[] less = array[1..].Where(x => x < pivot).ToArray();
            int[] greater = array[1..].Where(x => x > pivot).ToArray();

            return Invoke(less)
                .Concat(new int[] { pivot })
                .Concat(Invoke(greater))
                .ToArray();
        }
    }
}