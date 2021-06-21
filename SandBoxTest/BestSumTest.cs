namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class BestSumTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            int targetSum = 7;
            int[] numbers = { 5, 3, 4, 7 };
            var sut = new BestSum();
            int[] shortest = sut.Solution1(targetSum, numbers);
            Assert.AreEqual(new[]{ 7 }, shortest);
        }

        [Test]
        public void Solution1_TestCase2()
        {
            int targetSum = 0;
            int[] numbers = { 5, 3, 4, 7 };
            var sut = new BestSum();
            int[] shortest = sut.Solution1(targetSum, numbers);
            Assert.AreEqual(new int[0], shortest);
        }

        [Test]
        public void Solution1_TestCase3()
        {
            int targetSum = 0;
            int[] numbers = { 5, 3, 4, 7 };
            var sut = new BestSum();
            int[] shortest = sut.Solution1(targetSum, numbers);
            Assert.AreEqual(new int[0], shortest);
        }

        // will have to perform 10^10 operations, slow
        //[Test]
        //public void Solution1_TestCase4()
        //{
        //    int targetSum = 10;
        //    int[] numbers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        //    var sut = new BestSum();
        //    int[] shortest = sut.Solution1(targetSum, numbers);
        //    Assert.AreEqual(new[]{ 7 }, shortest);
        //}

        [Test]
        public void Solution2_TestCase1()
        {
            int targetSum = 7;
            int[] numbers = { 5, 3, 4, 7 };
            var sut = new BestSum();
            int[] shortest = sut.Solution2(targetSum, numbers);
            Assert.AreEqual(new[]{ 7 }, shortest);
        }

        [Test]
        public void Solution2_TestCase2()
        {
            int targetSum = 0;
            int[] numbers = { 5, 3, 4, 7 };
            var sut = new BestSum();
            int[] shortest = sut.Solution2(targetSum, numbers);
            Assert.AreEqual(new int[0], shortest);
        }

        [Test]
        public void Solution2_TestCase3()
        {
            int targetSum = 10;
            int[] numbers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var sut = new BestSum();
            int[] shortest = sut.Solution2(targetSum, numbers);
            Assert.AreEqual(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, shortest);
        }

        [Test]
        public void Solution2_TestCase4()
        {
            int targetSum = 100;
            int[] numbers = { 1, 2, 5, 25 };
            var sut = new BestSum();
            int[] shortest = sut.Solution2(targetSum, numbers);
            Assert.AreEqual(new[] { 25, 25, 25, 25 }, shortest);
        }

        [Test]
        public void Solution2_TestCase5()
        {
            int targetSum = 10;
            int[] numbers = { 7, 2, 1, 5 };
            var sut = new BestSum();
            int[] shortest = sut.Solution2(targetSum, numbers);
            Assert.AreEqual(new[] { 5, 5 }, shortest);
        }
    }
}
