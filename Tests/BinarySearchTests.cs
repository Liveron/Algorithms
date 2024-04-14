namespace Algorithms.Tests;

public class BinarySearchTests
{
    private static int[] CreateStubValidArray() => [1, 3, 5, 7, 9];

    [Fact]
    public void Invoke_ReturnsPosition()
    {
        int stubItemToSearch = 3;
        int[] stubArray = CreateStubValidArray();

        var result = BinarySearch.Invoke(stubArray, stubItemToSearch);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Invoke_WrongValueToSearch_ReturnsMinusOne()
    {
        int stubWrongItemToSearch = 0;
        int[] stubArray = CreateStubValidArray();

        var result = BinarySearch.Invoke(stubArray, stubWrongItemToSearch);

        Assert.Equal(-1, result);
    }
}