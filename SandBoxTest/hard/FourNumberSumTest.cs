namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class FourNumberSumTest
    {
        [Test]
        public void TestCase1()
        {
            int[] array = {7, 6, 4, -1, 1, 2};
            int targetSum = 16;
            var expected = new List<int[]>
            {
                new[] { 7, 6, 4, -1 },
                new[] { 7, 6, 1, 2 }
            };

            var actual = FourNumberSum.Solution1(array, targetSum);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
