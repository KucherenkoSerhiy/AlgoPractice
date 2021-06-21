namespace AlgoExpert
{
    public class SearchInSortedMatrix
    {
        // O(n + m) Time | O(1) Space, where n and m are width and height of the table respectively
        public static int[] Solve(int[,] matrix, int target)
        {
            var width = matrix.GetLength(1);

            int row = 0;
            int column = width - 1;
            int currentValue = matrix[row, column];

            while (row < width && column >= 0 && currentValue != target)
            {
                currentValue = matrix[row, column];
                if (currentValue < target)
                    row ++;
                else if (currentValue > target)
                    column--;
            }

            return currentValue == target ? new[] {row, column} : new[] {-1, -1};
        }
    }
}
