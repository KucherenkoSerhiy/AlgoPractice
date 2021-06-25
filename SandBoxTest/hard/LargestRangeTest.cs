namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class LargestRangeTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new[] {1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6};
            var expected = new[] {0, 7};
            var actual = LargestRange.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase2()
        {
            var array = new[] {1, 1};
            var expected = new[] {1, 1};
            var actual = LargestRange.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
