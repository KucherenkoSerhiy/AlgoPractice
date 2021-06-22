namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MinimumPassesOfMatrixTest
    {
        [Test]
        public void TestCase1()
        {
            var matrix = new[]
            {
                new[] { 0, -1, -3, 2, 0},
                new[] { 1, -2, -5, -1, -3},
                new[] { 3, 0, 0, -4, -1}
            };
            var expected = 3;
            var sut = new MinimumPassesOfMatrix();
            var actual = sut.Solve(matrix);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            var matrix = new[]
            {
                new[] { 0, -1, -3, 2, 0},
                new[] { 1, -2, -5, -1, 0},
                new[] { 3, 0, 0, 0, -1}
            };
            var expected = -1;
            var sut = new MinimumPassesOfMatrix();
            var actual = sut.Solve(matrix);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            var matrix = new[]
            {
                new[] { -3 }
            };
            var expected = -1;
            var sut = new MinimumPassesOfMatrix();
            var actual = sut.Solve(matrix);
            Assert.AreEqual(expected, actual);
        }
    }
}
