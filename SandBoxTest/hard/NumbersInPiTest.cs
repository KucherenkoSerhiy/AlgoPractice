namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NumbersInPiTest
    {
        [Test]
        public void TestCase1()
        {
            var pi = "3141592";
            string[] numbers = {"3141", "5", "31", "2", "4159", "9", "42"};
            var expected = 2;
            var actual = NumbersInPi.Solution(pi, numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            var pi = "3141592653589793238462643383279";
            string[] numbers = {"3141", "1512", "159", "793", "12412451", "8462643383279"};
            var expected = -1;
            var actual = NumbersInPi.Solution(pi, numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            var pi = "3141592653589793238462643383279";
            string[] numbers = {"3", "1", "4", "592", "65", "55", "35", "8", "9793", "2384626", "83279"};
            var expected = 13;
            var actual = NumbersInPi.Solution(pi, numbers);
            Assert.AreEqual(expected, actual);
        }
    }
}
