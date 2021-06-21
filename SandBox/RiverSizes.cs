namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;

    public class RiverSizes
    {
        public static List<int> Solution1(int[,] matrix)
        {
            var riverLengths = new List<int>();

            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);
            bool[,] visited = new bool[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (!visited[i, j])
                    {
                        var isRiver = matrix[i, j] == 1;
                        if (isRiver)
                        {
                            int riverLength = Dfs(matrix, ref visited, i, j);
                            riverLengths.Add(riverLength);
                        }

                        visited[i, j] = true;
                    }
                }
            }

            return riverLengths;
        }

        private static int Dfs(int[,] matrix, ref bool[,] visited, int i, int j)
        {
            bool isRowOutOfBounds = i < 0 || i >= matrix.GetLength(0);
            bool isColumnOutOfBounds = j < 0 || j >= matrix.GetLength(1);
            bool isOutOfBounds = isRowOutOfBounds || isColumnOutOfBounds;

            if (isOutOfBounds || matrix[i, j] == 0 || visited[i, j]) return 0;
            visited[i, j] = true;

            int currentLength = 1;
            int leftBranchLength = Dfs(matrix, ref visited, i, j - 1);
            int topBranchLength = Dfs(matrix, ref visited, i - 1, j);
            int rightBranchLength = Dfs(matrix, ref visited, i, j + 1);
            int bottomBranchLength = Dfs(matrix, ref visited, i + 1, j);

            int totalLength = currentLength + leftBranchLength + topBranchLength
                              + rightBranchLength + bottomBranchLength;
            return totalLength;
        }
    }
}
