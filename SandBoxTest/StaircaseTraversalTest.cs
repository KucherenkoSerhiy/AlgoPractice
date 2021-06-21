namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class StaircaseTraversalTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            var height = 4;
            var maxSteps = 2;
            var expected = 5;
            var sut = new StaircaseTraversal();
            var actual = sut.Solution1(height, maxSteps);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution1_TestCase2()
        {
            var height = 4;
            var maxSteps = 3;
            var expected = 7;
            var sut = new StaircaseTraversal();
            var actual = sut.Solution1(height, maxSteps);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution2_TestCase1()
        {
            var height = 4;
            var maxSteps = 2;
            var expected = 5;
            var sut = new StaircaseTraversal();
            var actual = sut.Solution2(height, maxSteps);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution2_TestCase2()
        {
            var height = 4;
            var maxSteps = 3;
            var expected = 7;
            var sut = new StaircaseTraversal();
            var actual = sut.Solution2(height, maxSteps);
            Assert.AreEqual(expected, actual);
        }
    }
}
