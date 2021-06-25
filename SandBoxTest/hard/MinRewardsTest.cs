namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MinRewardsTest
    {
        [Test]
        public void TestCase1()
        {
            int[] scores = {8, 4, 2, 1, 3, 6, 7, 9, 5};
            var expected = 25;
            var actual = MinRewards.Solve(scores);
            Assert.AreEqual(expected, actual);
        }
    }
}
