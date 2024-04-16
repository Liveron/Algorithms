namespace Algorithms.Common.Sort;

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

            return [.. Invoke(less), .. new int[] { pivot }, .. Invoke(greater)];
        }
    }
}