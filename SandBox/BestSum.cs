namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;

    // Find the shortest combination of numbers that add up to exactly the targetSum
    public class BestSum
    {
        // Brute Force
        // O(d^n * n) Time | O(d*n) Space, where d = number of elements in the array, and n = target number
        public int[] Solution1(int targetSum, int[] numbers)
        {
            if (targetSum == 0) return new int[0];
            if (targetSum < 0) return null;

            int[] shortestCombination = null;
            foreach (var number in numbers)
            {
                int remainder = targetSum - number;
                int[] remainderCombination = this.Solution1(remainder, numbers);
                if (remainderCombination != null)
                {
                    int[] combination = new int[remainderCombination.Length + 1];
                    Array.Copy(remainderCombination, combination, remainderCombination.Length);
                    combination[combination.Length - 1] = number;

                    if (shortestCombination == null || shortestCombination.Length > combination.Length)
                        shortestCombination = combination;
                }
            }

            return shortestCombination;
        }

        // Memoized
        // O(n^2*d) Time | O(n*d) Space, where d = number of elements in the array, and n = target number
        public int[] Solution2(int targetSum, int[] numbers)
        {
            var memo = new Dictionary<int, int[]>();
            var shortestSum =  this.Imm_Solution2(targetSum, numbers, ref memo);
            return shortestSum;
        }

        private int[] Imm_Solution2(int targetSum, int[] numbers, ref Dictionary<int, int[]> memo)
        {
            if (memo.ContainsKey(targetSum))
                return memo[targetSum];
            if (targetSum == 0) return new int[0];
            if (targetSum < 0) return null;

            int[] shortestCombination = null;
            foreach (var number in numbers)
            {
                int remainder = targetSum - number;
                int[] remainderCombination = this.Imm_Solution2(remainder, numbers, ref memo);
                if (remainderCombination != null)
                {
                    int[] combination = new int[remainderCombination.Length + 1];
                    Array.Copy(remainderCombination, combination, remainderCombination.Length);
                    combination[combination.Length - 1] = number;

                    if (shortestCombination == null || shortestCombination.Length > combination.Length)
                        shortestCombination = combination;
                }
            }
            memo.Add(targetSum, shortestCombination);

            return shortestCombination;
        }
    }
}
