using Algorithms.Common.Sort;

namespace Algorithms.Tests.Common;

public class SelectionSortTests
{
    private static int[] CreateStubValidArray() => [3, 1, 7, 5, 9];

    [Fact]
    public void Invoke_ReturnSortedArray()
    {
        int[] mockArray = CreateStubValidArray();

        SelectionSort.Invoke(mockArray);

        Assert.Equal(expected: [1, 3, 5, 7, 9], mockArray);
    }

    [Fact]
    public void Invoke_OneElementArray_ReturnArray()
    {
        int[] mockArray = [5];

        SelectionSort.Invoke(mockArray);

        Assert.Equal(expected: [5], mockArray);
    }
}