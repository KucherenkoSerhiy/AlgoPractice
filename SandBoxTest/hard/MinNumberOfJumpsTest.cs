namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MinNumberOfJumpsTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            var array = new[] {3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3};
            var expected = 4;
            var actual = MinNumberOfJumps.Solution1(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution2_TestCase1()
        {
            var array = new[] {3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3};
            var expected = 4;
            var actual = MinNumberOfJumps.Solution2(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution2_TestCase2()
        {
            var array = new[] {2, 1, 2, 3, 1};
            var expected = 2;
            var actual = MinNumberOfJumps.Solution2(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution3_TestCase1()
        {
            var array = new[] {3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3};
            var expected = 4;
            var actual = MinNumberOfJumps.Solution3(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution3_TestCase2()
        {
            var array = new[] {1};
            var expected = 0;
            var actual = MinNumberOfJumps.Solution3(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
