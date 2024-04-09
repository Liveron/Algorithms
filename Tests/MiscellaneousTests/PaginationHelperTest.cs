using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.MiscellaneousTests
{
    public class PaginationHelperTest
    {
        private readonly IList<char> collection = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };

        [Fact]
        public void ItemCount()
        {
            var paginationHelper = new PaginationHelper<char>(collection, 4);

            Assert.Equal(6, paginationHelper.ItemCount);
        }

        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 3)]
        [InlineData(4, 2)]
        public void PageCount(int itemsPerPage, int answer)
        {
            var paginationHelper = new PaginationHelper<char>(collection, itemsPerPage);

            Assert.Equal(answer, paginationHelper.PageCount);
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(0, 4)]
        [InlineData(1, 2)]
        [InlineData(2, -1)]
        public void PageItemCount(int pageNumber, int answer)
        {
            var paginationHelper = new PaginationHelper<char>(collection, 4);

            Assert.Equal(answer, paginationHelper.PageItemCount(pageNumber));
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(0, 0)]
        [InlineData(5, 1)]
        [InlineData(6, -1)]
        public void PageIndex(int itemIndex, int answer)
        {
            var paginationHelper = new PaginationHelper<char>(collection, 4);

            Assert.Equal(answer, paginationHelper.PageIndex(itemIndex));
        }
    }
}
