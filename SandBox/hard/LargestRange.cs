namespace AlgoExpert.hard
{
    using System.Collections.Generic;

    public class LargestRange
    {
        // O(n) Time | O(n) Space, where n = length of the array
        public static int[] Solve(int[] array) {
            var hashTable = new Dictionary<int, bool>();
            foreach (var value in array)
                hashTable[value] = false;

            int[] maxRange = null;
            foreach (int value in array){
                if (!hashTable[value]) { // skip the already count value
                    hashTable[value] = true;

                    // get the range
                    int left;
                    for (left = value - 1; hashTable.ContainsKey(left); left--)
                        hashTable[left] = true;
                    left++;

                    int right;
                    for (right = value + 1; hashTable.ContainsKey(right); right++)
                        hashTable[right] = true;
                    right--;
        
                    // compare and store obtained range
                    if (maxRange == null || maxRange[1] - maxRange[0] < right - left)
                    {
                        maxRange ??= new[] {0, 0};
                        maxRange[0] = left;
                        maxRange[1] = right;
                    }
                }
            }
            return maxRange;
        }
    }
}
