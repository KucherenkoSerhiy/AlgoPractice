using System.Collections.Generic;

namespace AlgoExpert
{
    public static class MoveElementToEnd
    {
        // O(n) Time | O(1) Space
        public static List<int> Solution1(List<int> array, int toMove)
        {
            int left = 0;
            int right = array.Count - 1;
            while (left < right)
            {
                if (array[left] != toMove) left++;
                if (array[right] == toMove) right--;

                if (array[left] == toMove && array[right] != toMove)
                {
                    Swap(array, left, right);
                }
            }

            return array;
        }

        private static void Swap(List<int> array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
