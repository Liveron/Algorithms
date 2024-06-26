﻿namespace Algorithms.CodeWars
{
    public static class ZerosToTheEnd
    {
        /// <summary>
        /// An algorithm that takes an array and
        /// moves all of the zeros to the end,
        /// preserving the order of the other elements
        /// </summary>
        /// <param name="arr">An input array</param>
        /// <returns>Sorted array</returns>
        public static int[] Invoke(int[] arr)
        {
            var newArr = new int[arr.Length];

            int zerosCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    newArr[i - zerosCount] = arr[i];

                else zerosCount++;
            }

            return newArr;
        }
    }
}
