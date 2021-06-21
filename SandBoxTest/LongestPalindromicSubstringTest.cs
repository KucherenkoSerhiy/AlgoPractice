namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class LongestPalindromicSubstringTest
    {
        [Test]
        public void TestCase1()
        {
            var str = "abaxyzzyxf";
            var expected = "xyzzyx";
            var actual = LongestPalindromicSubstring.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            var str = "abaxyzzzyxf";
            var expected = "xyzzzyx";
            var actual = LongestPalindromicSubstring.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            var str = "abaxyzzzzyxf";
            var expected = "xyzzzzyx";
            var actual = LongestPalindromicSubstring.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase4()
        {
            var str = "abaxyzzzzzyxf";
            var expected = "xyzzzzzyx";
            var actual = LongestPalindromicSubstring.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase5()
        {
            var str = "";
            var expected = "";
            var actual = LongestPalindromicSubstring.Solve(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase6()
        {
            var str = "zzzzzzz2345abbbba5432zzbbababa";
            var expected = "zz2345abbbba5432zz";
            var actual = LongestPalindromicSubstring.Solve(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
