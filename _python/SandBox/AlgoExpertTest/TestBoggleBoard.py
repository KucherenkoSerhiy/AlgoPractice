import unittest

from AlgoExpert import BoggleBoard


class TestBoggleBoard(unittest.TestCase):
    def test_something(self):
        board = [
          ["t", "h", "i", "s", "i", "s", "a"],
          ["s", "i", "m", "p", "l", "e", "x"],
          ["b", "x", "x", "x", "x", "e", "b"],
          ["x", "o", "g", "g", "l", "x", "o"],
          ["x", "x", "x", "D", "T", "r", "a"],
          ["R", "E", "P", "E", "A", "d", "x"],
          ["x", "x", "x", "x", "x", "x", "x"],
          ["N", "O", "T", "R", "E", "-", "P"],
          ["x", "x", "D", "E", "T", "A", "E"]
        ]
        words = ["this", "is", "not", "a", "simple", "boggle", "board", "test", "REPEATED", "NOTRE-PEATED"]
        expected = ["this", "is", "simple", "a", "boggle", "board", "NOTRE-PEATED"]
        actual = BoggleBoard.solution(board, words)
        self.assertEqual(expected, actual)