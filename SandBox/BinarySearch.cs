namespace AlgoExpert
{
    public static class BinarySearch
    {
        public static int Solution1(int[] array, int target)
        {
            return Imm_Solution1(array, target, 0, array.Length - 1);
        }

        private static int Imm_Solution1(int[] array, int target, int left, int right)
        {
            if (left > right) return -1;
            
            int median = (left + right) / 2;
            if (array[median] == target)
                return median;
            else if (array[median] < target)
                return Imm_Solution1(array, target, median + 1, right);
            
            return Imm_Solution1(array, target, left, median - 1);
        }

        // O(log(n)) Time | O(1) Space
        // Where n = total number of elements in the array
        public static int Solution2(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                if (array[(left + right) / 2] == target)
                    return (left + right) / 2;
                else if (array[(left + right) / 2] > target)
                    right = (left + right) / 2 - 1;
                else if (array[(left + right) / 2] < target)
                    left = (left + right) / 2 + 1;
            }

            return array[(left + right) / 2] == target ? (left + right) / 2 : -1;
        }
    }
}
