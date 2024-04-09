using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous
{
    public static class ZerosToTheEnd
    {
        /// <summary>
        /// An algorithm that takes an array and
        /// moves all of the zeros to the end,
        /// preserving the order of the other elements
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>int[]</returns>
        public static int[] Invoke(int[] arr)
        {
            int[] newArr = new int[arr.Length];

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
