namespace AlgoExpert
{
    using System.Collections.Generic;

    public class TrieNode {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    }

    public class SuffixTrie {
        public TrieNode root = new TrieNode();
        public char endSymbol = '*';

        public SuffixTrie(string str) {
            PopulateSuffixTrieFrom(str);
        }

        // O(n^2) Time | O(n^2) Space, where n = length of the str
        public void PopulateSuffixTrieFrom(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                var letter = str[i];
                if (!this.root.Children.ContainsKey(letter))
                    this.root.Children[letter] = new TrieNode();

                var currentNode = this.root.Children[letter];
                for (int j = i + 1; j < str.Length; j++)
                {
                    var nextLetter = str[j];

                    if (!currentNode.Children.ContainsKey(nextLetter))
                        currentNode.Children[nextLetter] = new TrieNode();


                    currentNode = currentNode.Children[nextLetter];
                }
                currentNode.Children[endSymbol] = null;
            }
        }

        // O(n) Time | O(1) Space, where n = length of the str
        public bool Contains(string str)
        {
            var currentNode = this.root;
            foreach (var letter in str)
            {
                if (!currentNode.Children.ContainsKey(letter)) return false;
                currentNode = currentNode.Children[letter];
            }

            return currentNode != null && currentNode.Children.ContainsKey(endSymbol);
        }
    }
}
