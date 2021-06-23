namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NextGreaterElementTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new[] { 2, 5, -3, -4, 6, 7, 2 };
            var expected = new[] { 5, 6, 6, 6, 7, -1, 5 };
            var sut = new NextGreaterElement();
            var actual = sut.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase2()
        {
            var array = new[] { 10 };
            var expected = new[] { -1 };
            var sut = new NextGreaterElement();
            var actual = sut.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void TestCase3()
        {
            var array = new[] { 1, 1, 1, 1 };
            var expected = new[] { -1, -1, -1, -1 };
            var sut = new NextGreaterElement();
            var actual = sut.Solve(array);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
