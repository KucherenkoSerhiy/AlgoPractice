namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class GroupAnagramsTest
    {
        [Test]
        public void TestCase1()
        {
            var words = new List<string>
            {
                "yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp"
            };
            var expected = new List<List<string>>
            {
                new List<string> {"foo"},
                new List<string> {"flop", "olfp"},
                new List<string> {"oy", "yo"},
                new List<string> {"act", "cat", "tac"}
            };

            var actual = GroupAnagrams.Solve(words);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
