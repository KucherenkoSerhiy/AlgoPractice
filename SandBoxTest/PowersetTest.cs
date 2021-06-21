namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class PowersetTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new List<int> { 1, 2, 3};
            var expected = new List<List<int>>
            {
                new List<int>{},
                new List<int>{1},
                new List<int>{2},
                new List<int>{3},
                new List<int>{1, 2},
                new List<int>{1, 3},
                new List<int>{2, 3},
                new List<int>{1, 2, 3}
            };
            var actual = Powerset.Solution(array);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
