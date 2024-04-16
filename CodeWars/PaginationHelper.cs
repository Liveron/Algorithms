namespace Algorithms.CodeWars
{
    public class PaginationHelper<T>
    {
        private IList<T> _collection;
        private int _itemsPerPage;

        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            _collection = collection;
            _itemsPerPage = itemsPerPage;
        }

        public int ItemCount => _collection.Count;
        public int PageCount
        {
            get
            {
                int result = _collection.Count / _itemsPerPage;
                return _collection.Count % _itemsPerPage == 0 ? result : result + 1;
            }
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0) { return - 1; }

            int result = _collection.Count - (pageIndex * _itemsPerPage);

            if (result <= 0)
            {
                return -1;
            }
            else if (result > _itemsPerPage)
            {
                return _itemsPerPage;
            }
            else 
            { 
                return result; 
            }
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex > _collection.Count - 1) 
            { 
                return -1; 
            }

            return itemIndex / _itemsPerPage;
        }
    }
}
