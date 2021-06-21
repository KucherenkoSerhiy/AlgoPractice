namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;

    public class MinimumCharactersForWords
    {
        // O(n*w) Time | O(n*w) Space, where n = number of words and w = avg word length
        public string[] Solve(string[] words)
        {
            var letterFrequencies = new Dictionary<char, int>();
            foreach (var word in words)
            {
                var currentWordLetterFrequencies = this.RetrieveCurrentWordLetterFrequencies(word);

                this.CountFrequencies(currentWordLetterFrequencies, letterFrequencies);
            }
            return this.ConvertToArray(letterFrequencies);
        }

        private Dictionary<char, int> RetrieveCurrentWordLetterFrequencies(string word)
        {
            var currentWordLetterFrequencies = new Dictionary<char, int>();
            foreach (var symbol in word)
            {
                if (!currentWordLetterFrequencies.ContainsKey(symbol))
                    currentWordLetterFrequencies.Add(symbol, 1);
                else
                    currentWordLetterFrequencies[symbol]++;
            }

            return currentWordLetterFrequencies;
        }

        private void CountFrequencies(Dictionary<char, int> currentWordLetterFrequencies, Dictionary<char, int> letterFrequencies)
        {
            foreach (var frequency in currentWordLetterFrequencies)
            {
                if (!letterFrequencies.ContainsKey(frequency.Key))
                    letterFrequencies.Add(frequency.Key, frequency.Value);
                else
                    letterFrequencies[frequency.Key] = Math.Max(frequency.Value, letterFrequencies[frequency.Key]);
            }
        }

        private string[] ConvertToArray(Dictionary<char, int> letterFrequencies)
        {
            var letters = new List<string>();
            foreach (var (letter, frequency) in letterFrequencies)
            {
                for (int i = 1; i <= frequency; i++)
                    letters.Add(letter.ToString());
            }

            return letters.ToArray();
        }
    }
}
