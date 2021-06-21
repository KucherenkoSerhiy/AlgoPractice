namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using NUnit.Framework;

    public class ValidateSubsequenceTest
    {
        [Test]
        public void TestCase1()
        {
            List<int> array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            List<int> sequence = new List<int>{1, 6, -1, 10};
            Assert.IsTrue(ValidateSubsequence.Solution1(array, sequence));
        }
        [Test]
        public void TestCase2()
        {
            List<int> array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            List<int> sequence = new List<int>{5, 1, 6};
            Assert.IsTrue(ValidateSubsequence.Solution1(array, sequence));
        }
        [Test]
        public void TestCase3()
        {
            List<int> array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            List<int> sequence = new List<int>{1, 10, -1};
            Assert.IsFalse(ValidateSubsequence.Solution1(array, sequence));
        }
        [Test]
        public void TestCase4()
        {
            List<int> array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            List<int> sequence = new List<int>{1, 25, -8};
            Assert.IsFalse(ValidateSubsequence.Solution1(array, sequence));
        }
        [Test]
        public void TestCase5()
        {
            List<int> array = new List<int>{1}; 
            List<int> sequence = new List<int>{1};
            Assert.IsTrue(ValidateSubsequence.Solution1(array, sequence));
        }
        [Test]
        public void TestCase6()
        {
            List<int> array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            List<int> sequence = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            Assert.IsTrue(ValidateSubsequence.Solution1(array, sequence));
        }
        [Test]
        public void TestCase7()
        {
            List<int> array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10}; 
            List<int> sequence = new List<int>{5, 10, 1, 10};
            Assert.IsFalse(ValidateSubsequence.Solution1(array, sequence));
        }
    }
}
