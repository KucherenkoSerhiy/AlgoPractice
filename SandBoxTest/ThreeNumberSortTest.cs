namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ThreeNumberSortTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new[] { 1, 0, 0, -1, -1, 0, 1, 1 };
            var order = new[] {0, 1, -1};
            var expected = new[] { 0, 0, 0, 1, 1, 1, -1, -1 };
            var sut = new ThreeNumberSort();
            var actual = sut.Solve(array, order);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
