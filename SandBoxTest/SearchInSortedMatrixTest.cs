namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SearchInSortedMatrixTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            var matrix = new[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            var target = 8;
            var expected = new[] { 1, 2 };
            var actual = SearchInSortedMatrix.Solve(matrix, target);
            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Solution1_TestCase2()
        {
            var matrix = new[,]
            {
                { 1, 2, 3 },
                { 4, 6, 7 },
                { 7, 8, 9 }
            };
            var target = 5;
            var expected = new[] { -1, -1 };
            var actual = SearchInSortedMatrix.Solve(matrix, target);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
