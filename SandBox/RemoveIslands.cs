namespace AlgoExpert
{
    public class RemoveIslands
    {
        public int[][] Solution1(int[][] matrix)
        {
            if (matrix.Length <= 2 || matrix[0]?.Length <= 2)
                return matrix;

            bool[,] visited = new bool[matrix.Length, matrix[0].Length];

            // Left Border
            for (int i = 0; i < matrix.Length; i++)
                this.MarkLandAsVisited(matrix, ref visited, i, 0);
            // Top Border
            for (int i = 0; i < matrix.Length; i++)
                this.MarkLandAsVisited(matrix, ref visited, 0, i);
            // Right Border
            for (int i = 0; i < matrix.Length; i++)
                this.MarkLandAsVisited(matrix, ref visited, i, matrix[0].Length - 1);
            // Bottom Border
            for (int i = 0; i < matrix.Length; i++)
                this.MarkLandAsVisited(matrix, ref visited, matrix.Length - 1, i);

            for (int i = 1; i < matrix.Length - 1; i++)
                for (int j = 1; j < matrix[0].Length - 1; j++)
                    if (!visited[i, j]) matrix[i][j] = 0;

            return matrix;
        }

        private void MarkLandAsVisited(int[][] matrix, ref bool[,] visited, int i, int j)
        {
            // Out of bounds
            if (i < 0 || i >= matrix.Length || j < 0 || j >= matrix[0].Length)
                return;

            // Already visited
            if (visited[i, j]) return;

            visited[i, j] = true;

            if (matrix[i][j] == 0) return;
            
            // Left
            if (j > 0 && matrix[i][j - 1] == 1) this.MarkLandAsVisited(matrix, ref visited, i, j - 1);
            // Top
            if (i > 0 && matrix[i - 1][j] == 1) this.MarkLandAsVisited(matrix, ref visited, i - 1, j);
            // Right
            if (j < matrix[0].Length - 1 && matrix[i][j + 1] == 1) this.MarkLandAsVisited(matrix, ref visited, i, j + 1);
            // Bottom
            if (i < matrix.Length - 1  && matrix[i + 1][j] == 1) this.MarkLandAsVisited(matrix, ref visited, i + 1, j);
        }
    }
}
