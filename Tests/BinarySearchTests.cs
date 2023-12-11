namespace Algorithms.Tests;

public class BinarySearchTests
{
    private int[] CreateIntArray() => new int[] { 1, 3, 5, 7, 9 };

    [Fact]
    public void Invoke_ReturnPosition()
    {
        const int STUB_ITEM_TO_SEARCH = 3;
        int[] stubArray = CreateIntArray();

        var result = BinarySearch.Invoke(stubArray, STUB_ITEM_TO_SEARCH);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Invoke_WrongValueToSearch_ReturnMinusOne()
    {
        const int STUB_WRONG_ITEM_TO_SEARCH = 0;
        int[] stubArray = CreateIntArray();

        var result = BinarySearch.Invoke(stubArray, STUB_WRONG_ITEM_TO_SEARCH);

        Assert.Equal(-1, result);
    }
}