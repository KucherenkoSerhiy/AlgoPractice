namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class HowSumTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            int target = 7;
            int[] values = {2, 4};
            int[] howSum = HowSum.Solution1(target, values);
            Assert.IsNull(howSum);
        }

        [Test]
        public void Solution1_TestCase2()
        {
            int target = 8;
            int[] values = {2, 3, 5};
            int[] howSum = HowSum.Solution1(target, values);
            Assert.AreEqual(new[] {2, 2, 2, 2}, howSum);
        }

        [Test]
        public void Solution1_TestCase3()
        {
            int target = 8;
            int[] values = {3, 5, 8};
            int[] howSum = HowSum.Solution1(target, values);
            Assert.AreEqual(new[] {3, 5}, howSum);
        }

        // will never end
        //[Test]
        //public void Solution1_TestCase4()
        //{
        //    int target = 999;
        //    int[] values = {2, 4, 6, 8, 10};
        //    int[] howSum = HowSum.Solution1(target, values);
        //    Assert.IsNull(howSum);
        //}

        [Test]
        public void Solution2_TestCase1()
        {
            int target = 7;
            int[] values = {2, 4};
            int[] howSum = HowSum.Solution2(target, values);
            Assert.IsNull(howSum);
        }

        [Test]
        public void Solution2_TestCase2()
        {
            int target = 8;
            int[] values = {2, 3, 5};
            int[] howSum = HowSum.Solution2(target, values);
            Assert.AreEqual(new[] {2, 2, 2, 2}, howSum);
        }

        [Test]
        public void Solution2_TestCase3()
        {
            int target = 8;
            int[] values = {3, 5, 8};
            int[] howSum = HowSum.Solution2(target, values);
            Assert.AreEqual(new[] {3, 5}, howSum);
        }

        [Test] 
        public void Solution2_TestCase4()
        {
            int target = 999;
            int[] values = { 2, 4, 6, 8, 10 };
            int[] howSum = HowSum.Solution2(target, values);
            Assert.IsNull(howSum);
        }

        [Test] 
        public void Solution2_TestCase5()
        {
            int target = 1000;
            int[] values = { 2, 4, 6, 8, 10 };
            int[] howSum = HowSum.Solution2(target, values);
            int[] expected = new int[500];
            for(int i = 0; i < 500; i++)
                expected[i] = 2;
            Assert.AreEqual(expected, howSum);
        }
        
        [Test]
        public void Solution3_TestCase1()
        {
            int target = 7;
            int[] values = {2, 4};
            var howSum = HowSum.Solution3(target, values);
            Assert.AreEqual(0, howSum[target].Count);
        }

        [Test]
        public void Solution3_TestCase2()
        {
            int target = 8;
            int[] values = {2, 3, 5};
            var howSum = HowSum.Solution3(target, values);
            Assert.AreEqual(3, howSum[target].Count);
        }

        [Test]
        public void Solution3_TestCase3()
        {
            int target = 8;
            int[] values = {3, 5, 8};
            var howSum = HowSum.Solution3(target, values);
            Assert.AreEqual(2, howSum[target].Count);
        }

        [Test] 
        public void Solution3_TestCase4()
        {
            int target = 99;
            int[] values = { 2, 4, 6, 8, 10 };
            var howSum = HowSum.Solution3(target, values);
            Assert.AreEqual(0, howSum[target].Count);
        }

        [Test] 
        public void Solution3_TestCase5()
        {
            int target = 100;
            int[] values = { 2, 4, 6, 8, 10 };
            var howSum = HowSum.Solution3(target, values);
            Assert.AreEqual(3765, howSum[target].Count);
        }

        [Test] 
        public void Solution3_TestCase6()
        {
            int target = 7;
            int[] values = { 5, 4, 3, 7 };
            var howSum = HowSum.Solution3(target, values);
            Assert.AreEqual(2, howSum[target].Count);
        }
    }
}
