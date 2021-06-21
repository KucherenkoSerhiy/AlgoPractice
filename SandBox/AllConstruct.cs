namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AllConstruct
    {
        // O(n^m*m) Time | O(n*m) Space, where n = number of words in wordbank, m = target length
        public List<Stack<string>> BruteForce(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return new List<Stack<string>>{new Stack<string>()};
            List<Stack<string>> response = new List<Stack<string>>();
            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target.Substring(word.Length, target.Length - word.Length);
                    List<Stack<string>> candidateResponses = this.BruteForce(suffix, wordBank);
                    foreach (var candidateResponse in candidateResponses)
                    {
                        candidateResponse.Push(word);
                        response.Add(candidateResponse);
                    }
                }
            }

            return response;
        }

        // O(n^m*m) Time | O(n^m) Space, where n = number of words in wordbank, m = target length
        public List<Stack<string>> Memoized(string target, string[] wordBank)
        {
            var memo = new Dictionary<string, List<Stack<string>>>();
            var response = this.Imm_Memoized(target, wordBank, ref memo);
            return response;
        }

        private List<Stack<string>> Imm_Memoized(string target, string[] wordBank, ref Dictionary<string, List<Stack<string>>> memo)
        {
            if (memo.ContainsKey(target))
            {
                return memo[target];
            }
            if (string.IsNullOrEmpty(target)) return new List<Stack<string>>{new Stack<string>()};
            List<Stack<string>> responses = new List<Stack<string>>();
            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target.Substring(word.Length, target.Length - word.Length);
                    List<Stack<string>> candidateResponses = this.Imm_Memoized(suffix, wordBank, ref memo);
                    foreach (var candidateResponse in candidateResponses)
                    {
                        candidateResponse.Push(word);
                        responses.Add(candidateResponse);
                    }
                }
            }
            
            List<Stack<string>> responsesClone = new List<Stack<string>>();
            foreach (var response in responses)
            {
                var responseClone = new Stack<string>();
                foreach (var registry in response)
                {
                    responseClone.Push(registry);
                }
                responsesClone.Add(responseClone);
            }
            memo.Add(target, responsesClone);
            return responses;
        }

        // O(n^m) Time | O(n^m) Space, where n = number of words in wordbank, m = target length 
        public List<List<string>> Tabulated(string target, string[] wordBank)
        {
            var table = new List<List<string>>[target.Length + 1];
            for (int i = 0; i < table.Length; i++) table[i] = new List<List<string>>();
            table[0].Add(new List<string>());

            for (int i = 0; i <= target.Length; i++)
            {
                if (table[i].Any())
                {
                    foreach (string word in wordBank)
                    {
                        if (target.Length >= i + word.Length &&
                            target.Substring(i, word.Length) == word)
                        {
                            var newRegistries = new List<List<string>>();
                            foreach (var registry in table[i])
                            {
                                var newRegistry = new List<string>();
                                newRegistry.AddRange(registry);
                                newRegistry.Add(word);
                                newRegistries.Add(newRegistry);
                            }

                            table[i + word.Length].AddRange(newRegistries);
                        }
                    }
                }
            }

            return table[target.Length];
        }
    }
}
