namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SortStackTest
    {
        [Test]
        public void TestCase1()
        {
            var stack = new List<int> { -5, 2, -2, 4, 3, 1 };
            var expected = new List<int> { -5, -2, 1, 2, 3, 4 };
            var sut = new SortStack();

            var actual = sut.Solve(stack);

            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
