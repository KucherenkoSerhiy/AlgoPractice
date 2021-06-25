namespace AlgoExpert.hard
{
    using System;

    public class SubarraySort
    {
        // O(n) Time | O(1) Space, where n = length of the array
        public static int[] Solve(int[] array)
        {
            // Step 1: find the breakage (if not found, the array is sorted)
            int left = 0;
            while (left < array.Length - 1 && array[left] <= array[left + 1])
                left++;
            if (left == array.Length - 1) return new[] {-1, -1}; // Array is sorted

            int right = array.Length -1;
            while (right > 0 && array[right - 1] <= array[right])
                right--;

            // Step 2: determine at which indexes the found values belong
            int currentLeft = array[left];
            while (left > 0 && array[left - 1] >= currentLeft)
                left --;
            int currentRight = array[right];
            while (right < array.Length - 1 && array[right + 1] <= currentRight)
                right ++;

            // Step 3: find the min and max values between left and right
            int unsortedMin = int.MaxValue;
            int unsortedMax = int.MinValue;
            for (int i = left; i <= right; i++)
            {
                unsortedMin = Math.Min(array[i], unsortedMin);
                unsortedMax = Math.Max(array[i], unsortedMax);
            }

            // Step 4: expand left and right up to where min and max values should be inserted
            while (left > 0 && array[left - 1] > unsortedMin)
                left --;
            while (right < array.Length - 1 && array[right + 1] < unsortedMax)
                right ++;

            return new[] {left, right};
        }
    }
}
