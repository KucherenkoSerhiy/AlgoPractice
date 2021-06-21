namespace AlgoExpert
{
    using System.Collections.Generic;

    public class ReverseWordsInString
    {
        // O(n) Time | O(n) space, where n = length of the input string
        public string Solve(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;

            var reversedWords = new Stack<string>();
            var currentWord = "";
            var currentWhiteSpace = "";
            for (int i = 0; i < str.Length; i++)
            {
                var letter = str[i];
                if (char.IsWhiteSpace(letter))
                {
                    if (!string.IsNullOrEmpty(currentWord))
                    {
                        reversedWords.Push(currentWord);
                        currentWord = "";
                    }
                    
                    currentWhiteSpace += letter;
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentWhiteSpace))
                    {
                        reversedWords.Push(currentWhiteSpace);
                        currentWhiteSpace = "";
                    }
                    
                    currentWord += letter;
                }
            }
            if (!string.IsNullOrEmpty(currentWord))
                reversedWords.Push(currentWord);
            if (!string.IsNullOrEmpty(currentWhiteSpace))
                reversedWords.Push(currentWhiteSpace);

            return string.Join("", reversedWords);
        }
    }
}
