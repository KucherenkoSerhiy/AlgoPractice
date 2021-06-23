namespace AlgoExpert
{
    using System.Collections.Generic;

    public class NextGreaterElement
    {
        // O(n) Time | O(n) Space, where n = length of the array
        public int[] Solve(int[] array)
        {
            var solution = new int[array.Length];
            for (int i = 0; i < solution.Length; i++)
                solution[i] = -1;

            if (array.Length <= 1)
                return solution;
            
            var currentStack = new Stack<(int index, int value)>();
            for (int i = 0; i < array.Length; i++)
            {
                while (currentStack.Count > 0 && currentStack.Peek().value < array[i])
                {
                    var index = currentStack.Pop().index;
                    solution[index] = array[i];
                }

                currentStack.Push((i, array[i]));
            }
            for (int i = 0; i < array.Length; i++)
            {
                while (currentStack.Count > 0 && currentStack.Peek().value < array[i])
                {
                    var index = currentStack.Pop().index;
                    solution[index] = array[i];
                }
            }

            return solution;
        }
    }
}
