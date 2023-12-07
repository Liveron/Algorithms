using Algorithms;

namespace Tests;

public class BinarySearchTests
{
    private int[] MakeStubIntArray() => new int[] { 1, 3, 5, 7, 9 };

    [Fact]
    public void Invoke_RandomValues_ReturnPosition()
    {
        const int STUB_ITEM_TO_SEARCH = 3;
        int[] stubArray = MakeStubIntArray();

        var result = BinarySearch.Invoke(stubArray, STUB_ITEM_TO_SEARCH);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Invoke_WrongValueToSearch_ReturnMinusOne()
    {
        const int STUB_WRONG_ITEM_TO_SEARCH = 0;
        int[] stubArray = MakeStubIntArray();

        var result = BinarySearch.Invoke(stubArray, STUB_WRONG_ITEM_TO_SEARCH);

        Assert.Equal(-1, result);
    }
}