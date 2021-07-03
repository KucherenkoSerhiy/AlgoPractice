namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DijkstrasAlgorithmTest
    {
        [Test]
        public void TestCase1()
        {
            int start = 0;
            int[][][] edges =
            {
                new[]
                {
                    new [] {1, 7}
                },
                new []
                {
                    new [] {2, 6},
                    new [] {3, 20},
                    new [] {4, 3}
                },
                new[]
                {
                    new [] {3, 14}
                },
                new[]
                {
                    new [] {4, 2}
                },
                new int[0][],
                new int[0][]
            };
            int[] expected = {0, 7, 13, 27, 10, -1};
            var sut = new DijkstrasAlgorithm();
            var actual = sut.Solution(start, edges);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
