namespace AlgoExpert.hard
{
    using System;

    public class MinNumberOfJumps
    {
        // O(n^2) Time | O(n) Space, where n = length of the array
        public static int Solution1(int[] array)
        {
            var table = new int[array.Length];
            for (int i = 1; i < table.Length; i++)
                table[i] = int.MaxValue;

            for (int i = 0; i < table.Length; i++)
            {
                int value = array[i];
                for (int j = i + 1; j <= Math.Min(i + value, table.Length - 1); j++)
                {
                    table[j] = Math.Min(table[i] + 1, table[j]);
                }
            }

            return table[table.Length - 1];
        }

        // O(n^2) Time | O(1) Space, where n = length of the array
        public static int Solution2(int[] array)
        {
            int jumps = 0;
            int currentIndex = 0;
            while (currentIndex < array.Length - 1)
            {
                int currentValue = array[currentIndex];
                int currentMaxPositionValueSum = 0;
                int targetIndex = -1;
                for (int i = currentIndex + 1; i <= Math.Min(currentIndex + currentValue, array.Length - 1); i++)
                {
                    if (i == array.Length - 1 || i + array[i] >= currentMaxPositionValueSum)
                    {
                        currentMaxPositionValueSum = i + array[i];
                        targetIndex = i;
                    }
                }

                jumps++;
                currentIndex = targetIndex;
            }

            return jumps;
        }

        // O(n) Time | O(1) Space, where n = length of the array
        public static int Solution3(int[] array)
        {
            if (array.Length <= 1) return 0;

            int jumps = 0;
            int maxReach = array[0];
            int steps = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                maxReach = Math.Max(maxReach, array[i] + i);
                steps--;
                if (steps == 0)
                {
                    jumps++;
                    steps = maxReach - i;
                }
            }

            jumps++;

            return jumps;
        }
    }
}
