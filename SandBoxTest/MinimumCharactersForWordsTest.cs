namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MinimumCharactersForWordsTest
    {
        [Test]
        public void TestCase1()
        {
            var words = new[] {"this", "that", "did", "deed", "them!", "a"};
            var expected = new[] {"!", "a", "d", "d", "e", "e", "h", "i", "m", "s", "t", "t"};
            var sut = new MinimumCharactersForWords();
            var actual = sut.Solve(words);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
