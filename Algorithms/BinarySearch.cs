﻿namespace Algorithms;
public class BinarySearch
{
    static int Invoke(int[] arrToSearch, int itemToSearch)
    {
        int low = 0;
        int high = arrToSearch.Length - 1;
        int mid;
        int guess;

        while (low <= high)
        {
            mid = (low + high) / 2;
            guess = arrToSearch[mid];

            if (guess == itemToSearch)
                return mid;

            else if (guess > itemToSearch)
                high = mid - 1;

            else low = mid + 1;
        }

        return -1;
    }
}
