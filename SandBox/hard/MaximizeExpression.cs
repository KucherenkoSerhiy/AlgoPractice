namespace AlgoExpert.hard
{
    using System;

    public class MaximizeExpression
    {
        // O(n) Time | O(n) Space, where n = length of the array
        public int Solution(int[] array)
        {
            if (array.Length < 4)
                return 0;

            var table = new int[4][];
            for (int i = 0; i < 4; i++)
                table[i] = new int[array.Length];

            // a
            table[0][0] = array[0];
            for (int i = 1; i < array.Length; i++)
                table[0][i] = Math.Max(array[i], table[0][i - 1]);

            // a - b
            table[1][1] = table[0][0] - array[1];
            for (int i = 2; i < array.Length; i++)
                table[1][i] = Math.Max(table[0][i-1] - array[i], table[1][i - 1]);

            // a - b + c
            table[2][2] = table[1][1] + array[2];
            for (int i = 3; i < array.Length; i++)
                table[2][i] = Math.Max(table[1][i-1] + array[i], table[2][i - 1]);

            // a - b + c - d
            table[3][3] = table[2][2] - array[3];
            for (int i = 4; i < array.Length; i++)
                table[3][i] = Math.Max(table[2][i-1] - array[i], table[3][i - 1]);

            return table[3][array.Length - 1];
        }
    }
}
