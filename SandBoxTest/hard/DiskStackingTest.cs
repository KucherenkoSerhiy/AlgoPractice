namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DiskStackingTest
    {
        [Test]
        public void TestCase1()
        {
            var disks = new List<int[]>
            {
                new[] { 2, 1, 2 },
                new[] { 3, 2, 3 },
                new[] { 2, 2, 8 },
                new[] { 2, 3, 4 },
                new[] { 1, 3, 1 },
                new[] { 4, 4, 5 },
            };
            var expected = new List<int[]>
            {
                new[] { 2, 1, 2 },
                new[] { 3, 2, 3 },
                new[] { 4, 4, 5 }
            };
            var actual = DiskStacking.Solution(disks);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase2()
        {
            var disks = new List<int[]>
            {
                new[] { 2, 1, 2 },
                new[] { 3, 2, 3 }
            };
            var expected = new List<int[]>
            {
                new[] { 2, 1, 2 },
                new[] { 3, 2, 3 }
            };
            var actual = DiskStacking.Solution(disks);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
