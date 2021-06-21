using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    public class ThreeNumberSumTest
    {
        [Test]
        public void TestCase1()
        {
            int[] array = {12, 3, 1, 2, -6, 5, -8, 6};
            int targetSum = 0;
            var expected = new List<int[]>
            {
                new[] {-8, 2, 6},
                new[] {-8, 3, 5},
                new[] {-6, 1, 5}
            };

            var actual = ThreeNumberSum.Solution1(array, targetSum);

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase2()
        {
            int[] array = {1, 2, 3};
            int targetSum = 6;
            var expected = new List<int[]>
            {
                new[] {1, 2, 3}
            };

            var actual = ThreeNumberSum.Solution1(array, targetSum);

            actual.Should().BeEquivalentTo(expected);
        }
        [Test]
        public void TestCase3()
        {
            int[] array = {0, 0, 0, 0, 0};
            int targetSum = 0;
            var expected = new List<int[]>
            {
                new[] {0, 0, 0},
                new[] {0, 0, 0},
                new[] {0, 0, 0},
                new[] {0, 0, 0}
            };

            var actual = ThreeNumberSum.Solution1(array, targetSum);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
