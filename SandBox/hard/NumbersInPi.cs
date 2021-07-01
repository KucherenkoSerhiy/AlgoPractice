namespace AlgoExpert.hard
{
    using System.Collections.Generic;

    public static class NumbersInPi
    {
        public static int Solution(string pi, string[] numbers)
        {
            var memo = new Dictionary<string, int>();
            var substrings = Imm_Substrings(pi, numbers, ref memo);
            if (substrings > 0) substrings--; // spaces = substrings -1
            return substrings;
        }

        // O(n^3 + m) Time | O(n*m) Space, where n = length of the pi array and m = length of the numbers array
        private static int Imm_Substrings(string pi, string[] numbers, ref Dictionary<string, int> memo)
        {
            if (string.IsNullOrEmpty(pi)) 
                return 0;
            if (memo.ContainsKey(pi))
                return memo[pi];

            var minSpaces = -1;
            foreach (var number in numbers)
            {
                if (pi.StartsWith(number))
                {
                    var suffixSpaces = Imm_Substrings(pi.Substring(number.Length), numbers, ref memo);
                    if (suffixSpaces != -1 && (minSpaces == -1 || suffixSpaces < minSpaces))
                        minSpaces = suffixSpaces + 1;
                }
            }

            if (minSpaces != -1 && !memo.ContainsKey(pi))
                memo.Add(pi, minSpaces);
            return minSpaces;
        }
    }
}
