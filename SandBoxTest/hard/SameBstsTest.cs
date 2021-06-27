namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SameBstsTest
    {
        [Test]
        public void Solution1_TestCase1_True()
        {
            var arrayOne = new List<int> {10, 15, 8, 12, 94, 81, 5, 2, 11};
            var arrayTwo = new List<int> {10, 8, 5, 15, 2, 12, 11, 94, 81};
            var areEqual = SameBsts.Solution1(arrayOne, arrayTwo);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void Solution1_TestCase2_False()
        {
            var arrayOne = new List<int> {10, 15, 8, 12, 94, 81, 5, 2, 11};
            var arrayTwo = new List<int> {10, 8, 5, 15, 2, 12, 11, 81, 94};
            var areEqual = SameBsts.Solution1(arrayOne, arrayTwo);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void Solution1_TestCase3_False()
        {
            var arrayOne = new List<int> {10, 15, 8, 12, 94, 81, 5, 2, 11};
            var arrayTwo = new List<int> {10, 8, 5, 15, 2, 12, 11, 94, 82};
            var areEqual = SameBsts.Solution1(arrayOne, arrayTwo);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void Solution2_TestCase1_True()
        {
            var arrayOne = new List<int> {10, 15, 8, 12, 94, 81, 5, 2, 11};
            var arrayTwo = new List<int> {10, 8, 5, 15, 2, 12, 11, 94, 81};
            var areEqual = SameBsts.Solution2(arrayOne, arrayTwo);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void Solution2_TestCase2_False()
        {
            var arrayOne = new List<int> {10, 15, 8, 12, 94, 81, 5, 2, 11};
            var arrayTwo = new List<int> {10, 8, 5, 15, 2, 12, 11, 81, 94};
            var areEqual = SameBsts.Solution2(arrayOne, arrayTwo);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void Solution2_TestCase3_False()
        {
            var arrayOne = new List<int> {10, 15, 8, 12, 94, 81, 5, 2, 11};
            var arrayTwo = new List<int> {10, 8, 5, 15, 2, 12, 11, 94, 82};
            var areEqual = SameBsts.Solution2(arrayOne, arrayTwo);
            Assert.IsFalse(areEqual);
        }
    }
}
