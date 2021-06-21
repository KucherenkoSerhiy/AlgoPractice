namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    public class MoveElementToEndTest
    {
        [Test]
        public void TestCase1()
        {
            List<int> array = new List<int>{ 2, 1, 2, 2, 2, 3, 4, 2};
            int toMove = 2;

            List<int> expected = new List<int>{4, 1, 3, 2, 2, 2, 2, 2};
            List<int> actual = MoveElementToEnd.Solution1(array, toMove);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
