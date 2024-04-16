namespace Algorithms.Tests.CodeWars
{
    public class PaginationHelperTest
    {
        private static char[] CreateStubArray() => ['a', 'b', 'c', 'd', 'e', 'f'];
        private const int STUB_ITEMS_PER_PAGE_COUNT = 4;

        [Fact]
        public void ItemCount_ReturnsItemsCount()
        {
            char[] stubArray = CreateStubArray();

            var paginationHelper = new PaginationHelper<char>(stubArray, STUB_ITEMS_PER_PAGE_COUNT);

            Assert.Equal(6, paginationHelper.ItemCount);
        }

        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 3)]
        [InlineData(4, 2)]
        public void PageCount_ReturnsPagesCount(int itemsPerPage, int answer)
        {
            char[] stubArray = CreateStubArray();

            var paginationHelper = new PaginationHelper<char>(stubArray, itemsPerPage);

            Assert.Equal(answer, paginationHelper.PageCount);
        }

        [Theory]
        [InlineData(0, 4)]
        [InlineData(1, 2)]
        public void PageItemCount_ReturnsPageItemCount(int pageNumber, int answer)
        {
            char[] stubArray = CreateStubArray();

            var paginationHelper = new PaginationHelper<char>(stubArray, STUB_ITEMS_PER_PAGE_COUNT);

            Assert.Equal(answer, paginationHelper.PageItemCount(pageNumber));
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(2, -1)]
        public void PageItemCount_WrongPage_ReturnsMunisOne(int pageNumber, int answer)
        {
            char[] stubArray = CreateStubArray();

            var paginationHelper = new PaginationHelper<char>(stubArray, STUB_ITEMS_PER_PAGE_COUNT);

            Assert.Equal(answer, paginationHelper.PageItemCount(pageNumber));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(5, 1)]
        public void PageIndex_ReturnsPageIndex(int itemIndex, int answer)
        {
            char[] stubArray = CreateStubArray();

            var paginationHelper = new PaginationHelper<char>(stubArray, STUB_ITEMS_PER_PAGE_COUNT);

            Assert.Equal(answer, paginationHelper.PageIndex(itemIndex));
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(6, -1)]
        public void PageIndex_WrongItemIndex_ReturnsMinusOne(int itemIndex, int answer)
        {
            char[] stubArray = CreateStubArray();

            var paginationHelper = new PaginationHelper<char>(stubArray, STUB_ITEMS_PER_PAGE_COUNT);

            Assert.Equal(answer, paginationHelper.PageIndex(itemIndex));
        }
    }
}
