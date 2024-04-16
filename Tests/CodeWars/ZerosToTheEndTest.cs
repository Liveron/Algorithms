namespace Algorithms.Tests.CodeWars
{
    public class ZerosToTheEndTest
    {
        private static int[] CreateStubValidArray() => [1, 2, 0, 1, 0, 1];

        [Fact]
        public void Invoke_ReturnsSortedArray()
        {
            int[] stubArray = CreateStubValidArray();

            int[] result = ZerosToTheEnd.Invoke(stubArray);

            Assert.Equal(expected: [1, 2, 1, 1, 0, 0], result);
        }
    }
}
