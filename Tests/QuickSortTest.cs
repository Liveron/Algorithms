namespace Algorithms;

public class QuickSortTests
{
    private int[] CreateUsortedIntArray() =>
        new int[] { 5, 1, 7, 3, 9 };

    [Fact]
    public void Invoke_ReturnSortedArray()
    {
        int[] stubArray = CreateUsortedIntArray();

        Assert.Equal(new int[] { 1, 3, 5, 7, 9 }, QuickSort.Invoke(stubArray));
    }
}