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

        public void PopulateSuffixTrieFrom(string str) {
            // TODO
        }

        public bool Contains(string str) {
            // TODO
            return false;
        }
    }
}
