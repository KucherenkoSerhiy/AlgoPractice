namespace AlgoExpert
{
    using System.Collections.Generic;
    using System.Linq;

    public class GroupAnagrams
    {
        // O(n*k*log(g)) Time | O(n*k) Space, where n = number of words and k = avg word length
        public static List<List<string>> Solve(List<string> words)
        {
            var groupedAnagrams = new Dictionary<string, List<string>>();
            foreach (var word in words)
            {
                var sortedWord = string.Concat(word.OrderBy(c => c));
                if (!groupedAnagrams.ContainsKey(sortedWord))
                    groupedAnagrams[sortedWord] = new List<string>{word};
                else
                    groupedAnagrams[sortedWord].Add(word);
            }

            return groupedAnagrams.Values.ToList();
        }
    }
}
