using System;
using System.Linq;

namespace AlgoExpert
{
    public class SortedSquaredArray
    {
        // O(n*log(n)) Time | O(n) Space - sort
        public int[] Solution1(int[] array)
        {
            var squaredNumbers = array.Select(x => x * x).ToArray();
            Array.Sort(squaredNumbers);
            return squaredNumbers;
        }

        // O(n) Time | O(n) Space
        public int[] Solution2(int[] array)
        {
            int[] squaredNumbers = new int[array.Length];
            int squaredNumbersIndex = 0;

            if (array.Length < 2)
                return array.Select(x => x*x).ToArray();

            int min = 0;
            while (min < array.Length - 1 && Math.Abs(array[min+1]) < Math.Abs(array[min]))
                min++;

            int left = min;
            int right = min + 1;

            int valueToInsert;
            while (left >= 0 || right < array.Length)
            {
                if (left < 0)
                {
                    valueToInsert = array[right] * array[right];
                    right++;
                }
                else if (right >= array.Length)
                {
                    valueToInsert = array[left] * array[left];
                    left--;
                }
                else
                {
                    if (Math.Abs(array[left]) < Math.Abs(array[right]))
                    {
                        valueToInsert = array[left] * array[left];
                        left--;
                    }
                    else
                    {
                        valueToInsert = array[right] * array[right];
                        right++;
                    }
                }

                squaredNumbers[squaredNumbersIndex] = valueToInsert;
                squaredNumbersIndex++;
            }
            return squaredNumbers;
        }
    }
}
