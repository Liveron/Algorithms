using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.MiscellaneousTests
{
    public class ZerosToTheEndTest
    {
        [Theory]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1, 2, 0, 1, 0, 1 }, new int[] {1, 2, 1, 1, 0, 0})]
        public void Invoke_ValidArr(int[] inputArr, int[] outArr)
        {
            int[] result = ZerosToTheEnd.Invoke(inputArr);
            Assert.Equal(outArr, result);
        }
    }
}
