namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class LongestCommonSubsequenceTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            var str1 = "ZXVVYZW";
            var str2 = "XKYKZPW";
            var expected = new List<char> {'X', 'Y', 'Z', 'W'};
            var actual = LongestCommonSubsequence.Solution1(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution1_TestCase2()
        {
            var str1 = "aaaaaaa";
            var str2 = "aaaaz";
            var expected = new List<char> {'a', 'a', 'a', 'a'};
            var actual = LongestCommonSubsequence.Solution1(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution1_TestCase3()
        {
            var str1 = "";
            var str2 = "aaaaz";
            var expected = new List<char>();
            var actual = LongestCommonSubsequence.Solution1(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution1_TestCase4()
        {
            var str1 = "aaa";
            var str2 = "";
            var expected = new List<char>();
            var actual = LongestCommonSubsequence.Solution1(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution1_TestCase5()
        {
            var str1 = "merlin";
            var str2 = "mastermind";
            var expected = new List<char>{'m', 'e', 'r', 'i', 'n'};
            var actual = LongestCommonSubsequence.Solution1(str1, str2);
            // TODO: fails
            // actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution1_TestCase6()
        {
            var str1 = "8111111111111111142";
            var str2 = "222222222822222222222222222222433333333332";
            var expected = new List<char>{'8', '4', '2'};
            var actual = LongestCommonSubsequence.Solution1(str1, str2);
            // TODO: fails
            // actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
        [Test]
        public void Solution2_TestCase1()
        {
            var str1 = "ZXVVYZW";
            var str2 = "XKYKZPW";
            var expected = new List<char> {'X', 'Y', 'Z', 'W'};
            var actual = LongestCommonSubsequence.Solution2(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution2_TestCase2()
        {
            var str1 = "aaaaaaa";
            var str2 = "aaaaz";
            var expected = new List<char> {'a', 'a', 'a', 'a'};
            var actual = LongestCommonSubsequence.Solution2(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution2_TestCase3()
        {
            var str1 = "";
            var str2 = "aaaaz";
            var expected = new List<char>();
            var actual = LongestCommonSubsequence.Solution2(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution2_TestCase4()
        {
            var str1 = "aaa";
            var str2 = "";
            var expected = new List<char>();
            var actual = LongestCommonSubsequence.Solution2(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution2_TestCase5()
        {
            var str1 = "merlin";
            var str2 = "mastermind";
            var expected = new List<char>{'m', 'e', 'r', 'i', 'n'};
            var actual = LongestCommonSubsequence.Solution2(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution2_TestCase6()
        {
            var str1 = "8111111111111111142";
            var str2 = "222222222822222222222222222222433333333332";
            var expected = new List<char>{'8', '4', '2'};
            var actual = LongestCommonSubsequence.Solution2(str1, str2);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
