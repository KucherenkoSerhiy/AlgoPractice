namespace AlgoExpert
{
    public class ThreeNumberSort
    {
        // O(n) Time | O(1) Space, where n = length of the array
        public int[] Solve(int[] array, int[] order)
        {
            int first = 0;
            int second = 0;
            int third = array.Length - 1;
            while (second <= third)
            {
                if (array[second] == order[0])
                {
                    int temp = array[first];
                    array[first] = array[second];
                    array[second] = temp;

                    first ++;
                    second ++;
                }
                else if (array[second] == order[2])
                {
                    int temp = array[third];
                    array[third] = array[second];
                    array[second] = temp;

                    third--;
                }
                else 
                    second ++;
            }

            return array;
        }
    }
}
