namespace AlgoExpert
{
    using System;

    public class LongestPalindromicSubstring
    {
        // O(n^2) Time | O(n) Space, where n = length of the input string
        public static string Solve(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;

            var maxPalindrom = "";
            for (var i = 0; i < str.Length; i++)
            {
                var currentPalindrom = str[i].ToString();
                int left = i - 1;
                int right = i + 1;

                if (left >= 0 && str[left] == str[i] && (right >= str.Length || str[right] != str[i]))
                {
                    while (left >= 0 && str[left] == str[i])
                    {
                        currentPalindrom = str[left] + currentPalindrom;
                        left--;
                    }
                }
                while (left >= 0 && right < str.Length && str[left] == str[right])
                {
                    currentPalindrom = str[left] + currentPalindrom + str[right];
                    
                    left--;
                    right++;
                }

                if (currentPalindrom.Length > maxPalindrom.Length)
                    maxPalindrom = currentPalindrom;
            }

            return maxPalindrom;
        }
    }
}
