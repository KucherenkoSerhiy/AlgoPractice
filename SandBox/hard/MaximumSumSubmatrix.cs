namespace AlgoExpert.hard
{
    using System;

    public class MaximumSumSubmatrix
    {
        // O(n*m Time) | O(n*m) Space, where n and m are height and width of the matrix
        public int Solution1(int[,] matrix, int size)
        {
            var height = matrix.GetLength(0);
            var width = matrix.GetLength(1);
            var sums = new int[height, width];
            
            // build the accumulative sum matrix
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var topSum = i > 0 ? sums[i - 1, j] : 0;
                    var leftSum = j > 0 ? sums[i, j - 1] : 0;
                    var topLeftSum = i > 0 && j > 0 ? sums[i - 1, j - 1] : 0;
                    sums[i, j] = matrix[i, j] + leftSum + topSum - topLeftSum;
                }
            }

            int maxSum = int.MinValue;
            for (int i = size - 1; i < height; i++)
            {
                for (int j = size - 1; j < width; j++)
                {
                    var topSum = i - size >= 0 ? sums[i - size, j] : 0;
                    var leftSum = j - size >= 0 ? sums[i, j - size] : 0;
                    var topLeftSum = i  - size >= 0 && j  - size >= 0 ? sums[i - size, j - size] : 0;
                    var sum = sums[i, j] + topLeftSum - topSum - leftSum;
                    maxSum = Math.Max(maxSum, sum);
                }
            }
            
            return maxSum;
        }
    }
}
