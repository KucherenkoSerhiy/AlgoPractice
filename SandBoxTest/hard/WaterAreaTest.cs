namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class WaterAreaTest
    {
        [Test]
        public void TestCase1()
        {
            int[] heights = {0, 8, 0, 0, 5, 0, 0, 10, 0, 0, 1, 1, 0, 3};
            var expected = 48;
            var actual = WaterArea.Solve(heights);
            Assert.AreEqual(expected, actual);
        }
    }
}
