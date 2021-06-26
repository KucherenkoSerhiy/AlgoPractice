namespace AlgoExpert.hard
{
    using System.Collections.Generic;

    public class ZigzagTraverse
    {
        // O(n*m) Time | O(n*m) Space, where n and m are width and length of the array respectively
        public static List<int> Solve(List<List<int> > array)
        {
            if (array.Count == 0) return new List<int>();

            int i = 0;
            int j = 0;
            bool descending = true;

            var solution = new List<int>();
            int numberOfElements = array.Count * array[0].Count;
            
            solution.Add(array[i][j]);
            while (solution.Count < numberOfElements)
            {
                if (descending)
                {
                    // bottom-left
                    while (i < array.Count - 1 && j > 0)
                    {
                        i++;
                        j--;
                        solution.Add(array[i][j]);
                    }

                    // bottom or right
                    if (i < array.Count - 1)
                        i++;
                    else
                        j++;
                    solution.Add(array[i][j]);
                    descending = false;
                }
                else
                {
                    // top-right
                    while (i > 0 && j < array[0].Count - 1)
                    {
                        i--;
                        j++;
                        solution.Add(array[i][j]);
                    }

                    // right or bottom
                    if (j < array[0].Count - 1)
                        j++;
                    else
                        i++;
                    solution.Add(array[i][j]);
                    descending = true;
                }
            }

            return solution;
        }
    }
}
