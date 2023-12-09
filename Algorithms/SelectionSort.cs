namespace Algorithms;
public static class SelectionSort
{
    private static int FindSmallest(int[] array, int seekStartIndex)
    {
        int smallest = array[seekStartIndex];

        for (int i = seekStartIndex; i < array.Length; i++)
            if (array[i] < smallest)
            {
                smallest = array[i];
                seekStartIndex = i;
            }

        return seekStartIndex;
    }

    private static void Swap(ref int x, ref int y) =>
        (y, x) = (x, y);


    public static void Invoke(int[] array, int sortStartIndex = 0)
    {
        if (sortStartIndex == array.Length - 1)
            return;

        int smallestItemIndex = FindSmallest(array, sortStartIndex);

        if (smallestItemIndex != sortStartIndex)
            Swap(ref array[sortStartIndex], ref array[smallestItemIndex]);

        Invoke(array, sortStartIndex + 1);
    }
}