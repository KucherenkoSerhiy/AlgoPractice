namespace AlgoExpertTest
{
    using System;
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void Solution1_TestCase1()
        {

            Assert.AreEqual(1, Fibonacci.Solution1(1));
            Assert.AreEqual(13, Fibonacci.Solution1(6));
            Assert.AreEqual(34, Fibonacci.Solution1(8));
            Assert.AreEqual(89, Fibonacci.Solution1(10));
            // int fib50 = Fibonacci.Solution1(50); - will last eternity
        }

        [Test]
        public void Solution2_TestCase1()
        {

            Assert.AreEqual(1, Fibonacci.Solution2(1));
            Assert.AreEqual(13, Fibonacci.Solution2(6));
            Assert.AreEqual(34, Fibonacci.Solution2(8));
            Assert.AreEqual(89, Fibonacci.Solution2(10));
            Assert.AreEqual(12586269025L, Fibonacci.Solution2(49));
            long fib50 = Fibonacci.Solution2(50);
        }

        [Test]
        public void Solution3_TestCase1()
        {

            Assert.AreEqual(1, Fibonacci.Solution3(1));
            Assert.AreEqual(8, Fibonacci.Solution3(6));
            Assert.AreEqual(21, Fibonacci.Solution3(8));
            Assert.AreEqual(89, Fibonacci.Solution3(11));
            Assert.AreEqual(12586269025L, Fibonacci.Solution3(50));
        }
    }
}
