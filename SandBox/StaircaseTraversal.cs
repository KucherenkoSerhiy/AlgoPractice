namespace AlgoExpert
{
    using System.Collections.Generic;
    using System.Linq;

    public class StaircaseTraversal
    {
        // O(n*m) Time | O(n) Space, where n = height and m = maxSteps
        public int Solution1(int height, int maxSteps)
        {
            if (height <= 1) return 1;

            var table = new int[height + 1];
            table[0] = 1;
            table[1] = 1;
            for (int current = 2; current <= height; current++)
            {
                int currentSum = 0;
                for (int i = current - 1; i >= 0 && current - i <= maxSteps; i--)
                    currentSum += table[i];
                table[current] = currentSum;
            }

            return table[height];
        }

        // O(n) Time | O(min(n, m)) Space, where n = height and m = maxSteps
        public int Solution2(int height, int maxSteps)
        {
            if (height <= 1 || maxSteps == 1) return 1;

            var window = new List<int>{1, 1};

            for (int current = 2; current <= height; current++)
            {
                int currentSum = window.Sum();
                if (window.Count == maxSteps)
                    window.RemoveAt(0);
                window.Add(currentSum);
            }

            return window.Last();
        }
    }
}
