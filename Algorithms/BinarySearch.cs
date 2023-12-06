namespace Algorithms;
public class BinarySearch
{
    static int Invoke(int[] arrToSearch, int itemToSearch)
    {
        int low = 0;
        int high = arrToSearch.Length - 1;
        int mid;
        int guessPosition;

        while (low <= high)
        {
            mid = (low + high) / 2;
            guessPosition = arrToSearch[mid];

            if (guessPosition == itemToSearch)
                return mid;

            else if (guessPosition > itemToSearch)
                high = mid - 1;

            else low = mid + 1;
        }

        return -1;
    }
}
