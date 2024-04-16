using Algorithms.Common.Sort;

namespace Algorithms.Tests.Common;

public class QuickSortTests
{
    private static int[] CreateStubValidArray() => [5, 1, 7, 3, 9];

    [Fact]
    public void Invoke_ReturnsSortedArray()
    {
        int[] stubArray = CreateStubValidArray();

        Assert.Equal(expected: [1, 3, 5, 7, 9], QuickSort.Invoke(stubArray));
    }
}