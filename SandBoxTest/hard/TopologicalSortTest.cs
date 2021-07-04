namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class TopologicalSortTest
    {
        [Test]
        public void TestCase1_NormalGraph_Ok()
        {
            var jobs = new List<int> {1, 2, 3, 4};
            var deps = new List<int[]>
            {
                new[]{1, 2},
                new[]{1, 3},
                new[]{3, 2},
                new[]{4, 2},
                new[]{4, 3}
            };
            var expected = new[] {1, 4, 3, 2};
            var actual = TopologicalSort.Solution(jobs, deps);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase2_DisconnectedGraph_Ok()
        {
            var jobs = new List<int> {1, 2, 3, 4};
            var deps = new List<int[]>
            {
                new[]{1, 2},
                new[]{1, 3},
                new[]{3, 2}
            };
            var expected = new[] {1, 3, 2, 4};
            var actual = TopologicalSort.Solution(jobs, deps);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase3_CycledGraph_EmptyResult()
        {
            var jobs = new List<int> {1, 2, 3};
            var deps = new List<int[]>
            {
                new[]{1, 2},
                new[]{2, 1}
            };
            var actual = TopologicalSort.Solution(jobs, deps);
            actual.Should().BeEquivalentTo(new List<int>());
        }
    }
}
