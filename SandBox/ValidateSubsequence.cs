namespace AlgoExpert
{
    using System.Collections.Generic;

    public static class ValidateSubsequence
    {
        // O(N) Time | O(1) Space
        public static bool Solution1(List<int> array, List<int> sequence)
        {
            int sequenceIndex = 0;

            foreach (var arrayValue in array)
            {
                bool isMatch = arrayValue == sequence[sequenceIndex];
                if (isMatch)
                    sequenceIndex++;
                if (sequenceIndex == sequence.Count)
                    return true;
            }

            return false;
        }
    }
}
