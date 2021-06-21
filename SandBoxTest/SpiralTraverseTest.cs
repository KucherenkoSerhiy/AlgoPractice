using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    public class SpiralTraverseTest
    {
        [Test]
        public void TestCase1()
        {
            int[,] array = {
                {1,   2,  3, 4},
                {12, 13, 14, 5},
                {11, 16, 15, 6},
                {10,  9,  8, 7}
            };
            List<int> expected = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            List<int> actual = SpiralTraverse.Solution1(array);
            actual.Should().BeEquivalentTo(expected);
            List<int> actual2 = SpiralTraverse.Solution2(array);
            actual2.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase2()
        {
            int[,] array = {
                {4, 2, 3, 6, 7, 8, 1, 9, 5, 10},
                {12, 19, 15, 16, 20, 18, 13, 17, 11, 14}
            };
            List<int> expected = new List<int>
            {
                4, 2, 3, 6, 7, 8, 1, 9, 5, 10, 12, 19, 15, 16, 20, 18, 13, 17, 11, 14
            };

            List<int> actual = SpiralTraverse.Solution1(array);
            actual.Should().BeEquivalentTo(expected);
            List<int> actual2 = SpiralTraverse.Solution2(array);
            actual2.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase3()
        {
            int[,] array = {
                {4, 2, 3, 6, 7, 8, 1, 9, 5, 10},
                {12, 19, 15, 16, 20, 18, 13, 17, 11, 14}
            };
            List<int> expected = new List<int>
            {
                4, 2, 3, 6, 7, 8, 1, 9, 5, 10, 12, 19, 15, 16, 20, 18, 13, 17, 11, 14
            };

            List<int> actual = SpiralTraverse.Solution1(array);
            actual.Should().BeEquivalentTo(expected);
            List<int> actual2 = SpiralTraverse.Solution2(array);
            actual2.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase4()
        {
            int[,] array = {
                {1, 2, 3},
                {8, 9, 4},
                {7, 6, 5}
            };
            List<int> expected = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            List<int> actual = SpiralTraverse.Solution1(array);
            actual.Should().BeEquivalentTo(expected);
            List<int> actual2 = SpiralTraverse.Solution2(array);
            actual2.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase5()
        {
            int[,] array = {
                {1,   2,  3, 4},
                {10, 11, 12, 5},
                {9,   8,  7, 6}
            };
            List<int> expected = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            List<int> actual = SpiralTraverse.Solution1(array);
            actual.Should().BeEquivalentTo(expected);
            List<int> actual2 = SpiralTraverse.Solution2(array);
            actual2.Should().BeEquivalentTo(expected);
        }
    }
}
