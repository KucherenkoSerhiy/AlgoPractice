namespace AlgoExpert.hard
{
    using System;
    using System.Linq;

    public class MinRewards
    {
        // O(n) Time | O(1) Space, where n = length of the array
        public static int Solve(int[] scores) {
            // left swipe
            for (int i = 0; i < scores.Length; i++)
                Minimize(scores, i);

            // right swipe
            for (int i = scores.Length - 1; i >= 0; i--)
                Minimize(scores, i);

            return scores.Sum();
        }

        private static void Minimize(int[] scores, int i)
        {
            int leftNeighbor = i == 0 || scores[i - 1] > scores[i] ? 0 : scores[i - 1];
            int rightNeighbor = i == scores.Length - 1 || scores[i + 1] > scores[i] ? 0 : scores[i + 1];
            int minPossible = Math.Max(leftNeighbor, rightNeighbor) + 1;
            scores[i] = minPossible;
        }
    }
}
