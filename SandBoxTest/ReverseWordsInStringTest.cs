namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ReverseWordsInStringTest
    {
        [Test]
        public void TestCase1()
        {
            var str = "AlgoExpert is the best!";
            var expected = "best! the is AlgoExpert";
            var sut = new ReverseWordsInString();
            var actual = sut.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            var str = "AlgoExpert   is  the best!";
            var expected = "best! the  is   AlgoExpert";
            var sut = new ReverseWordsInString();
            var actual = sut.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            var str = "        test";
            var expected = "test        ";
            var sut = new ReverseWordsInString();
            var actual = sut.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase4()
        {
            var str = "test        ";
            var expected = "        test";
            var sut = new ReverseWordsInString();
            var actual = sut.Solve(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
