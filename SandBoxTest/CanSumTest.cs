namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class CanSumTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            int n = 7;
            int[] coins = new[] { 5, 3, 4, 7 };
            bool canSum = CanSum.Solution1(n, coins);
            Assert.IsTrue(canSum);
        }

        [Test]
        public void Solution1_TestCase2()
        {
            int n = 8;
            int[] coins = new[] { 5, 3, 4, 7 };
            bool canSum = CanSum.Solution1(n, coins);
            Assert.IsTrue(canSum);
        }

        [Test]
        public void Solution1_TestCase3()
        {
            int n = 5;
            int[] coins = new[] { 4, 3, 4, 7 };
            bool canSum = CanSum.Solution1(n, coins);
            Assert.IsFalse(canSum);
        }

        // will never end
        //[Test]
        //public void Solution1_TestCase4()
        //{
        //    int n = 1001;
        //    int[] coins = new[] {2, 2, 2, 2};
        //    bool canSum = CanSum.Solution1(n, coins);
        //    Assert.IsFalse(canSum);
        //}

        [Test]
        public void Solution2_TestCase1()
        {
            int n = 7;
            int[] coins = new[] { 5, 3, 4, 7 };
            bool canSum = CanSum.Solution2(n, coins);
            Assert.IsTrue(canSum);
        }

        [Test]
        public void Solution2_TestCase2()
        {
            int n = 8;
            int[] coins = new[] { 5, 3, 4, 7 };
            bool canSum = CanSum.Solution2(n, coins);
            Assert.IsTrue(canSum);
        }

        [Test]
        public void Solution2_TestCase3()
        {
            int n = 5;
            int[] coins = new[] { 4, 3, 4, 7 };
            bool canSum = CanSum.Solution2(n, coins);
            Assert.IsFalse(canSum);
        }

        [Test]
        public void Solution2_TestCase4()
        {
            int n = 1001;
            int[] coins = new[] { 2, 2, 2, 2 };
            bool canSum = CanSum.Solution2(n, coins);
            Assert.IsFalse(canSum);
        }
        
        [Test]
        public void Solution3_TestCase1()
        {
            int n = 7;
            int[] coins = new[] { 5, 3, 4, 7 };
            bool canSum = CanSum.Solution3(n, coins);
            Assert.IsTrue(canSum);
        }

        [Test]
        public void Solution3_TestCase2()
        {
            int n = 8;
            int[] coins = new[] { 5, 3, 4, 7 };
            bool canSum = CanSum.Solution3(n, coins);
            Assert.IsTrue(canSum);
        }

        [Test]
        public void Solution3_TestCase3()
        {
            int n = 5;
            int[] coins = new[] { 4, 3, 4, 7 };
            bool canSum = CanSum.Solution3(n, coins);
            Assert.IsFalse(canSum);
        }

        [Test]
        public void Solution3_TestCase4()
        {
            int n = 1001;
            int[] coins = { 2, 2, 2, 2 };
            bool canSum = CanSum.Solution3(n, coins);
            Assert.IsFalse(canSum);
        }
    }
}
