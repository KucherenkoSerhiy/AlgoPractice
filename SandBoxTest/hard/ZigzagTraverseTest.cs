namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ZigzagTraverseTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new List<List<int>>
            {
                new List<int>{1, 3, 4, 10},
                new List<int>{2, 5, 9, 11},
                new List<int>{6, 8, 12, 15},
                new List<int>{7, 13, 14, 16}
            };
            var expected = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            var actual = ZigzagTraverse.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
        [Test]
        public void TestCase2()
        {
            var array = new List<List<int>>
            {
                new List<int>{1, 2, 3, 4, 5}
            };
            var expected = new List<int> {1, 2, 3, 4, 5};
            var actual = ZigzagTraverse.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
