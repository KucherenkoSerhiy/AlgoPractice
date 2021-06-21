namespace AlgoExpert
{
    using System.Collections.Generic;

    public class CountConstruct
    {
        // O(n^m*m) Time, O(m^2) Space, where n = number of words in the wordBank, m = target length
        public int BruteForce(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return 1;

            int totalCount = 0;
            foreach (string word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string candidate = target.Substring(word.Length, target.Length - word.Length);
                    int candidateCount = this.BruteForce(candidate, wordBank);
                    totalCount += candidateCount;
                }
            }

            return totalCount;
        }

        public int Memoized(string target, string[] wordBank)
        {
            var memo = new Dictionary<string, int>();
            int solution = this.Imm_Memoized(target, wordBank, ref memo);
            return solution;
        }

        // O(n*m^2) Time | O(m^2) Space, where n = number of words in the wordBank, m = target length
        private int Imm_Memoized(string target, string[] wordBank, ref Dictionary<string, int> memo)
        {
            if (memo.ContainsKey(target)) return memo[target];
            if (string.IsNullOrEmpty(target)) return 1;

            int totalCount = 0;
            foreach (string word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string candidate = target.Substring(word.Length, target.Length - word.Length);
                    int candidateCount = this.Imm_Memoized(candidate, wordBank, ref memo);
                    totalCount += candidateCount;
                }
            }

            memo[target] = totalCount;
            return totalCount;
        }

        // O(n*m^2) Time | O(m) Space, where n = number of words in wordbank, m = target length
        public int Tabulated(string target, string[] wordBank)
        {
            int[] table = new int[target.Length+1];
            table[0] = 1;

            for (int i = 0; i <= target.Length; i++)
            {
                if (table[i] > 0)
                {
                    foreach (string word in wordBank)
                    {
                        if (target.Length >= i + word.Length &&
                            target.Substring(i, word.Length) == word)
                        {
                            table[i + word.Length] += table[i];
                        }
                    }
                }
            }

            return table[target.Length];
        }
    }
}
