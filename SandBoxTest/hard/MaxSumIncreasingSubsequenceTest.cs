namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MaxSumIncreasingSubsequenceTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new[] {10, 70, 20, 30, 50, 11, 30};
            var expected = new List<List<int>>
            {
                new List<int>{110}, // sum
                new List<int>{10, 20, 30, 50} // sequence
            };
            var actual = MaxSumIncreasingSubsequence.Solution(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase2()
        {
            var array = new[] {-1};
            var expected = new List<List<int>>
            {
                new List<int>{-1}, // sum
                new List<int>{-1} // sequence
            };
            var actual = MaxSumIncreasingSubsequence.Solution(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase3()
        {
            var array = new[] {-5, -4, -3, -2, -1};
            var expected = new List<List<int>>
            {
                new List<int>{-1}, // sum
                new List<int>{-1} // sequence
            };
            var actual = MaxSumIncreasingSubsequence.Solution(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
