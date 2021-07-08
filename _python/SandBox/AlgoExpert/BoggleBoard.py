class TrieNode:
    def __init__(self):
        self.children = {}
        self.parent = None


class SuffixTrie:
    endSymbol = '*'

    def __init__(self, words):
        self.root = TrieNode()
        for word in words:
            self.populate(word)

    def populate(self, word):
        node = self.root
        for i in range(len(word)):
            letter = word[i]
            if letter not in node.children:
                parent = node
                node.children[letter] = TrieNode()
                node.parent = parent
            node = node.children[letter]
        parent = node
        node.children[SuffixTrie.endSymbol] = TrieNode()
        node.parent = parent


def dfs(board, i, j, words_trie_node, visited, solution, accumulated_word=""):
    if visited[i][j]:
        return

    letter = board[i][j]
    if letter in words_trie_node.children:
        # visit current position
        visited[i][j] = True
        accumulated_word += letter
        words_trie_node = words_trie_node.children[letter]
        if SuffixTrie.endSymbol in words_trie_node.children:
            if accumulated_word not in solution:
                solution.append(accumulated_word)
        # visit near positions (8 possible in total)
        if i > 0 and j < len(board[0]) - 1:  # top-right
            dfs(board, i - 1, j + 1, words_trie_node, visited, solution, accumulated_word)
        if j < len(board[0]) - 1:  # right
            dfs(board, i, j + 1, words_trie_node, visited, solution, accumulated_word)
        if i < len(board) - 1 and j < len(board[0]) - 1:  # bottom-right
            dfs(board, i + 1, j + 1, words_trie_node, visited, solution, accumulated_word)
        if i < len(board) - 1:  # bottom
            dfs(board, i + 1, j, words_trie_node, visited, solution, accumulated_word)
        if i < len(board) - 1 and j > 0:  # bottom-left
            dfs(board, i + 1, j - 1, words_trie_node, visited, solution, accumulated_word)
        if j > 0:  # left
            dfs(board, i, j - 1, words_trie_node, visited, solution, accumulated_word)
        if i > 0 and j > 0:  # top-left
            dfs(board, i - 1, j - 1, words_trie_node, visited, solution, accumulated_word)
        if i > 0:  # top
            dfs(board, i - 1, j, words_trie_node, visited, solution, accumulated_word)
        # unvisit current position
        visited[i][j] = False
        accumulated_word = accumulated_word[:-1]
        words_trie_node = words_trie_node.parent

# O(nm*8^s + ws) Time | O(nm + ws) Space, where
#    n and m are width and height of the matrix,
#    w is length of the array and s is the longest word length in the array
def solution(board, words):
    words_suffix_trie = SuffixTrie(words)
    visited = [[False for j in range(len(board[0]))] for i in range(len(board))]
    solution = []
    for i in range(len(board)):
        for j in range(len(board[0])):
            dfs(board, i, j, words_suffix_trie.root, visited, solution)
    return solution
