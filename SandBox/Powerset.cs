namespace AlgoExpert
{
    using System.Collections.Generic;
    using System.Linq;

    public class Powerset
    {
        // O(n*2^n) Time | O(n*2^n) Space, where n = length of the array
        public static List<List<int> > Solution(List<int> array)
        {
            var solution = new List<List<int>>();
            FillWithValues(array, solution);
            return solution;
        }

        private static void FillWithValues(List<int> array, List<List<int>> solution)
        {
            for (int i = array.Count - 1; i >= 0; i--)
            {
                var candidate = new List<int>(array);
                candidate.RemoveAt(i);
                FillWithValues(candidate, solution);
            }
            var registry = new List<int>(array);

            if (!solution.Any(x => x.SequenceEqual(registry)))
                solution.Add(registry);
        }
    }
}
