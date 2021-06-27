namespace AlgoExpert.hard
{
    using System;
    using System.Collections.Generic;

    public static class MaxSumIncreasingSubsequence
    {
        // O(n^2) Time | O(n) Space, where n = length of the array
        public static List<List<int> > Solution(int[] array)
        {
            (int sum, int max, List<int> sequence) maxSum = (int.MinValue, int.MinValue, new List<int>());
            var sums = new List<(int sum, int max, List<int> sequence)>();
            foreach (var value in array)
            {
                (int sum, int max, List<int> sequence) newSum = (value, value, new List<int>());
                (int sum, int max, List<int> sequence) currentAcceptableMaxSum = (int.MinValue, int.MinValue, new List<int>());
                foreach (var existingSum in sums)
                {
                    if (value > existingSum.max && existingSum.sum > currentAcceptableMaxSum.sum)
                    {
                        currentAcceptableMaxSum = existingSum;
                    }
                }

                if (currentAcceptableMaxSum.sum > 0)
                {
                    newSum.sum += currentAcceptableMaxSum.sum;
                    newSum.max = Math.Max(currentAcceptableMaxSum.max, value);
                    newSum.sequence.AddRange(currentAcceptableMaxSum.sequence);
                }
                
                newSum.sequence.Add(value);

                sums.Add(newSum);

                if (maxSum.sum < newSum.sum)
                    maxSum = newSum;
            }

            return new List<List<int>>
            {
                new List<int>{maxSum.sum},
                maxSum.sequence
            };
        }
    }
}
