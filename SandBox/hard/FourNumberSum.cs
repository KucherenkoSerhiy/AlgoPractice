namespace AlgoExpert.hard
{
    using System.Collections.Generic;
    using System.Linq;

    public class FourNumberSum
    {
        // O(n^3) Time | O(n^2) Space, where n = length of the array
        public static List<int[]> Solution1(int[] array, int targetSum)
        {
            var solution = new List<int[]>();
            var twoValueSums = new Dictionary<int, List<int[]>>();
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var currentPair = new[] { array[i], array[j] };
                    var currentSum = array[i] + array[j];
                    if (twoValueSums.ContainsKey(targetSum - currentSum))
                    {
                        foreach (var twoValueSum in twoValueSums[targetSum - currentSum])
                        {
                            if (!twoValueSum.Contains(array[i]) && !twoValueSum.Contains(array[j]))
                            {
                                int[] candidate = {array[i], array[j], twoValueSum[0], twoValueSum[1]};
                                if (!solution.Any(x => x.OrderBy(value => value).SequenceEqual(candidate.OrderBy(value => value))))
                                    solution.Add(candidate);
                            }
                        }
                    }
                    if (!twoValueSums.ContainsKey(currentSum))
                        twoValueSums[currentSum] = new List<int[]>();
                    twoValueSums[currentSum].Add(currentPair);
                }
            }

            return solution;
        }
    }
}
