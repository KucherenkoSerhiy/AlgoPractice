import unittest

from AlgoExpert.ContinuousMedianHandler import ContinuousMedianHandler


class TestContinuousMedianHandler(unittest.TestCase):
    def test_something(self):
        sut = ContinuousMedianHandler()
        sut.insert(5)
        self.assertEqual(5, sut.median)
        sut.insert(10)
        self.assertEqual(7.5, sut.median)
        sut.insert(100)
        self.assertEqual(10, sut.median)
        sut.insert(200)
        self.assertEqual(55, sut.median)
        sut.insert(6)
        self.assertEqual(10, sut.median)
        sut.insert(13)
        self.assertEqual(11.5, sut.median)
        sut.insert(14)
        self.assertEqual(13, sut.median)
        sut.insert(1000)
        self.assertEqual(13.5, sut.median)
