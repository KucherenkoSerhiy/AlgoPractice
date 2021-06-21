using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    public class LongestPeakTest
    {
        [Test]
        public void TestCase1()
        {
            int[] array = {1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3};
            int expected = 6;
            int actual = LongestPeak.Solution1(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            int[] array = {3, 3, 3, 3, 0, 4, 4, 4};
            int expected = 0;
            int actual = LongestPeak.Solution1(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            int[] array = {3, 3, 3, 3, 4, 0, 0, 0};
            int expected = 3;
            int actual = LongestPeak.Solution1(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase4()
        {
            int[] array = {};
            int expected = 0;
            int actual = LongestPeak.Solution1(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase5()
        {
            int[] array = {1, 3, 2};
            int expected = 3;
            int actual = LongestPeak.Solution1(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
