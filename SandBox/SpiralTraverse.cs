using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public static class SpiralTraverse
    {
        public static List<int> Solution1(int[,] array) {
            List<int> result = new List<int>();
            int n = array.GetLength(1);
            int m = array.GetLength(0);
            int completedTop = 0, completedBottom = 0, completedRight = 0, completedLeft = 0;

            bool completed = false;
            while (!completed)
            {
                // top
                if (!completed)
                {
                    for (int i = completedLeft; i < n - completedRight; i++)
                        result.Add(array[completedTop, i]);
                    completedTop++;
                }
                completed = completedRight + completedLeft >= n
                            || completedTop + completedBottom >= m;
                
                // right
                if (!completed)
                {
                    for (int i = completedTop; i < m - completedBottom; i++)
                        result.Add(array[i, n - 1 - completedRight]);
                    completedRight++;
                }
                completed = completedRight + completedLeft >= n
                            || completedTop + completedBottom >= m;
                
                // bottom
                if (!completed)
                {
                    for (int i = n - 1 - completedRight; i >= completedLeft; i--)
                        result.Add(array[m - 1 - completedBottom, i]);
                    completedBottom++;
                }
                completed = completedRight + completedLeft >= n
                            || completedTop + completedBottom >= m;

                // left
                if (!completed)
                {
                    for (int i = m - 1 - completedBottom; i >= completedTop; i--)
                        result.Add(array[i, completedLeft]);
                    completedLeft++;
                }
                completed = completedRight + completedLeft >= n
                            || completedTop + completedBottom >= m;
                
            }
		
            return result;
        }

        public static List<int> Solution2(int[,] array) {
            List<int> result = new List<int>();

            int startingRow = 0;
            int endingRow = array.GetLength(0) - 1;
            int startingColumn = 0;
            int endingColumn = array.GetLength(1) - 1;

            while (startingRow <= endingRow && startingColumn <= endingColumn)
            {
                for (int i = startingColumn; i <= endingColumn; i++)
                    result.Add(array[startingRow, i]);
                for (int i = startingRow+1; i <= endingRow; i++)
                    result.Add(array[i, endingColumn]);
                for (int i = endingColumn - 1; i >= startingColumn; i--)
                {
                    // handle the corner case with odd rows
                    if (startingRow == endingRow) break;
                    result.Add(array[endingRow, i]);
                }

                for (int i = endingRow - 1; i > startingRow; i--)
                {
                    // handle the corner case with odd columns
                    if (startingColumn == endingColumn) break;
                    result.Add(array[i, startingColumn]);
                }

                startingRow++;
                startingColumn++;
                endingRow--;
                endingColumn--;
            }

            return result;
        }
    }
}
