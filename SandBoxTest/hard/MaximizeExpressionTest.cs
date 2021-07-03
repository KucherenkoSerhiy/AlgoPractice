namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MaximizeExpressionTest
    {
        [Test]
        public void TestCase1()
        {
            int[] array = {3, 6, 1, -3, 2, 7};
            var expected = 4;
            var sut = new MaximizeExpression();
            var actual = sut.Solution(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            int[] array = {3, 6, 1};
            var expected = 0;
            var sut = new MaximizeExpression();
            var actual = sut.Solution(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
