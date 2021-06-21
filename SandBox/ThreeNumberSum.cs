using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public static class ThreeNumberSum
    {
        public static List<int[]> Solution1(int[] array, int targetSum) {
            List<int[]> result = new List<int[]>();
		
            if (array.Length < 3) return result;
            Array.Sort(array);
		
            int i = 0;
            while (i < array.Length - 2){
                int left = i+1;
                int right = array.Length - 1;
                while (left < right){
                    int sum = array[i] + array[left] + array[right];
                    if (sum < targetSum)
                        left++;
                    else if (sum > targetSum)
                        right--;
                    else if (sum == targetSum){
                        result.Add(new[] {array[i], array[left], array[right]});
                        left++;
                        right--;
                    }
                }
			
                i++;
            }
            return result;
        }
    }
}
