namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SubarraySortTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new[] {1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19};
            var expected = new[] {3, 9};
            var actual = SubarraySort.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase2()
        {
            var array = new[] {1, 2, 4, 7, 10, 11, 16, 18, 19};
            var expected = new[] {-1, -1};
            var actual = SubarraySort.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase3()
        {
            var array = new[] {1, 2, 4, 4, 3, -1, 99, 4, 4, 3, 7};
            var expected = new[] {0, 10};
            var actual = SubarraySort.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase4()
        {
            var array = new[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89};
            var expected = new[] {-1, -1};
            var actual = SubarraySort.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
