namespace AlgoExpert
{
    using System.Collections.Generic;

    public class MinimumPassesOfMatrix
    {
        // O(n*m) Time | O(w*h) Space, where w and h are width and height of the matrix
        public int Solve(int[][] matrix)
        {
            int negativesCount = 0;
            var currentPositivesQueue = new Queue<(int x, int y)>();
            var nextPositivesQueue = new Queue<(int x, int y)>();
            
            // initial setup: count negatives and enqueue positives
            for (int x = 0; x < matrix.Length; x++)
            {
                for (int y = 0; y < matrix[0].Length; y++)
                {
                    if (matrix[x][y] < 0)
                        negativesCount++;
                    else if (matrix[x][y] > 0)
                        currentPositivesQueue.Enqueue((x, y));
                }
            }

            if (currentPositivesQueue.Count == 0) return -1;

            int passes = 0;
            while (currentPositivesQueue.Count > 0 && negativesCount > 0)
            {
                bool didConversion = false;
                while (currentPositivesQueue.Count > 0)
                {
                    var currentPositive = currentPositivesQueue.Dequeue();
                    
                    // left
                    if (currentPositive.x >= 1 && matrix[currentPositive.x - 1][currentPositive.y] < 0)
                    {
                        didConversion = true;
                        negativesCount--;
                        nextPositivesQueue.Enqueue((currentPositive.x - 1, currentPositive.y));
                        matrix[currentPositive.x - 1][currentPositive.y] *= -1;
                    }
                    // top
                    if (currentPositive.y >= 1 && matrix[currentPositive.x][currentPositive.y - 1] < 0)
                    {
                        didConversion = true;
                        negativesCount--;
                        nextPositivesQueue.Enqueue((currentPositive.x, currentPositive.y - 1));
                        matrix[currentPositive.x][currentPositive.y - 1] *= -1;
                    }
                    // right
                    if (currentPositive.x < matrix.Length - 1 && matrix[currentPositive.x + 1][currentPositive.y] < 0)
                    {
                        didConversion = true;
                        negativesCount--;
                        nextPositivesQueue.Enqueue((currentPositive.x + 1, currentPositive.y));
                        matrix[currentPositive.x + 1][currentPositive.y] *= -1;
                    }
                    // bottom
                    if (currentPositive.y < matrix[0].Length - 1 && matrix[currentPositive.x][currentPositive.y + 1] < 0)
                    {
                        didConversion = true;
                        negativesCount--;
                        nextPositivesQueue.Enqueue((currentPositive.x, currentPositive.y + 1));
                        matrix[currentPositive.x][currentPositive.y + 1] *= -1;
                    }
                }

                if (!didConversion) return negativesCount == 0? passes : -1;

                currentPositivesQueue = nextPositivesQueue;
                nextPositivesQueue = new Queue<(int x, int y)>();
                passes++;
            }

            return passes;
        }
    }
}
