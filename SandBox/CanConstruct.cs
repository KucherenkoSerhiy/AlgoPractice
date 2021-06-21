namespace AlgoExpert
{
    using System.Collections.Generic;

    public class CanConstruct
    {
        // O(n^m*m) Time | O(m^2) Space, where m = target length, n = number of words in wordBank
        public bool BruteForce(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return true;

            bool response = false;
            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string candidate = target.Substring(word.Length, target.Length - word.Length);
                    bool canConstructCandidate = this.BruteForce(candidate, wordBank);
                    if (canConstructCandidate)
                        response = true;
                }
            }

            return response;
        }

        // O(n*m^2) Time | O(m^2) Space, where m = target length, n = number of words in wordBank
        public bool Memoized(string target, string[] wordBank)
        {
            var memo = new Dictionary<string, bool>();
            return this.Imm_Memoized(target, wordBank, ref memo);
        }

        private bool Imm_Memoized(string target, string[] wordBank, ref Dictionary<string, bool> memo)
        {
            if (memo.ContainsKey(target)) return memo[target];
            if (string.IsNullOrEmpty(target)) return true;

            bool response = false;
            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string candidate = target.Substring(word.Length, target.Length - word.Length);
                    bool canConstructCandidate = this.Imm_Memoized(candidate, wordBank, ref memo);
                    if (canConstructCandidate)
                        response = true;
                }
            }

            memo.Add(target, response);
            return response;
        }
        
        // O(n*m^2) Time | O(m) Space, where m = target length, n = number of words in wordBank
        public bool Tabulated(string target, string[] wordBank)
        {
            bool[] table = new bool[target.Length + 1];
            table[0] = true;

            for (int i = 0; i <= target.Length; i++)
            {
                if (table[i])
                {
                    foreach (string word in wordBank)
                    {
                        // if the word matches the characters starting at position i
                        if (target.Length >= i+word.Length && 
                            target.Substring(i, word.Length) == word)
                        {
                            table[i + word.Length] = true;
                        }
                    }
                }
            }

            return table[target.Length];
        }

    }
}
