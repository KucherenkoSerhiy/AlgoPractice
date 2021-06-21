using System;
using System.Collections;

public static class TwoNumberSum
{
    // O(n^2) Time | O(1) Space
    public static int[] Solution1(int[] array, int targetSum)
    {
        Hashtable passedValues = new Hashtable();
		
        for (int i = 0; i < array.Length - 1; i++){
            for (int j = i+1; j < array.Length; j++){
                if (array[i] + array[j] == targetSum)
                    return new int[]{array[i], array[j]};
            }
        }
		
        return new int[0];
    }

    // O(n) Time | O(n) Space
    public static int[] Solution2(int[] array, int targetSum)
    {
        Hashtable passedValues = new Hashtable();
		
        for (int i = 0; i < array.Length; i++){
            int value1 = array[i];
            int desiredValue = targetSum - value1;
            if (passedValues.ContainsKey(desiredValue))
                return new int []{desiredValue, value1};
            else
                passedValues.Add(value1, true);
        }
		
        return new int[0];
    }

    // O(n*log(n)) Time | O(1) Space
    public static int[] Solution3(int[] array, int targetSum)
    {
        Array.Sort(array);
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            if (array[left] + array[right] == targetSum)
                return new[] {array[left], array[right]};
            else if (array[left] + array[right] < targetSum)
                left++;
            else if (array[left] + array[right] > targetSum)
                right--;
        }
		
        return new int[0];
    }
}