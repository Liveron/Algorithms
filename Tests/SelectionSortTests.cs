namespace Algorithms.Tests;

public class SelectionSortTests
{
    private int[] CreateUnsortedIntArray() =>
        new int[5] { 3, 1, 7, 5, 9 };

    [Fact]
    public void Invoke_ReturnSortedArray()
    {
        int[] mockArray = CreateUnsortedIntArray();

        SelectionSort.Invoke(mockArray);

        Assert.Equal(new int[5] { 1, 3, 5, 7, 9 }, mockArray);
    }

    [Fact]
    public void Invoke_OneElementArray_ReturnArray()
    {
        int[] mockArray = new int[1] { 5 };

        SelectionSort.Invoke(mockArray);

        Assert.Equal(new int[1] { 5 }, mockArray);
    }
}