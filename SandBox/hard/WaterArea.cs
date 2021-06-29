namespace AlgoExpert.hard
{
    using System;
    using System.Linq;

    public static class WaterArea
    {
        // O(n) Time | O(n) Space, where n is the length of the array
        public static int Solve(int[] heights)
        {
            int[] maxPillarHeights = new int[heights.Length];

            // left swipe
            int currentMaxPillarHeight = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (currentMaxPillarHeight < heights[i])
                    currentMaxPillarHeight = heights[i];
                maxPillarHeights[i] = currentMaxPillarHeight;
            }

            // right swipe
            currentMaxPillarHeight = 0;
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                if (currentMaxPillarHeight < heights[i])
                    currentMaxPillarHeight = heights[i];
                maxPillarHeights[i] = Math.Min(currentMaxPillarHeight, maxPillarHeights[i]);
            }

            int sum = heights.Select((t, i) => maxPillarHeights[i] - t).Sum();
            return sum;
        }
    }
}
