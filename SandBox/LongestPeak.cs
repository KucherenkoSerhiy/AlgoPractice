using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public static class LongestPeak
    {
        public static int Solution1(int[] array)
        {
            if (array.Length < 2) return 0;

            int maxPeakLength = 0;
            int i = 1;

            while (i < array.Length)
            {
                // run up to peak
                while (i < array.Length && array[i] >= array[i - 1])
                    i++;

                // count peak length
                int currentPeakLength = CountPeakLength(array, i - 1);
                if (currentPeakLength > maxPeakLength)
                    maxPeakLength = currentPeakLength;
                
                // run down from peak
                while (i < array.Length && array[i] <= array[i - 1])
                    i++;
            }

            return maxPeakLength;
        }

        private static int CountPeakLength(int[] array, int i)
        {
            if (i == 0 || i == array.Length - 1) return 0;

            int left = i-1, right = i+1;
            int leftLength = 0, rightLength = 0;

            while (left >= 0 && array[left] < array[left + 1])
            {
                leftLength++;
                left--;
            }

            while (right < array.Length && array[right] < array[right - 1])
            {
                rightLength++;
                right++;
            }

            if (leftLength == 0 || rightLength == 0) return 0;
            return leftLength + 1 + rightLength;
        }
    }
}
