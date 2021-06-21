namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        public void TestCase1()
        {
            int[] array = new[] {0, 1, 21, 33, 45, 45, 61, 71, 72, 73};
            Assert.AreEqual(3, BinarySearch.Solution1(array, 33));
            Assert.AreEqual(3, BinarySearch.Solution2(array, 33));
        }
        
        [Test]
        public void TestCase2()
        {
            int[] array = new[] {0, 1, 21, 33, 45, 45, 61, 71, 72};
            Assert.AreEqual(3, BinarySearch.Solution1(array, 33));
            Assert.AreEqual(3, BinarySearch.Solution2(array, 33));
        }
        
        [Test]
        public void TestCase3()
        {
            int[] array = {0};
            Assert.AreEqual(0, BinarySearch.Solution1(array, 0));
            Assert.AreEqual(0, BinarySearch.Solution2(array, 0));
        }
        
        [Test]
        public void TestCase4()
        {
            int[] array = {0, 1};
            Assert.AreEqual(0, BinarySearch.Solution1(array, 0));
            Assert.AreEqual(0, BinarySearch.Solution2(array, 0));
        }
        
        [Test]
        public void TestCase5()
        {
            int[] array = {0, 1};
            Assert.AreEqual(1, BinarySearch.Solution1(array, 1));
            Assert.AreEqual(1, BinarySearch.Solution2(array, 1));
        }
        
        [Test]
        public void TestCase6()
        {
            int[] array = {1};
            Assert.AreEqual(-1, BinarySearch.Solution1(array, 0));
            Assert.AreEqual(-1, BinarySearch.Solution2(array, 0));
        }
    }
}
