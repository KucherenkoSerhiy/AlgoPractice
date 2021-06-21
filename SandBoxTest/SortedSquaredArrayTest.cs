using AlgoExpert;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoExpertTest
{
    [TestFixture]
    public class SortedSquaredArrayTest
    {
        [Test]
        public void TestCase1_Solution1()
        {
            int[] array = new[] {1, 2, 3, 5, 6, 8, 9};
            int[] expectedSolution = new[] {1, 4, 9, 25, 36, 64, 81};
            var sut = new SortedSquaredArray();
            var solution = sut.Solution1(array);
            solution.Should().BeEquivalentTo(expectedSolution);
        }

        [Test]
        public void TestCase1_Solution2()
        {
            int[] array = new[] {1, 2, 3, 5, 6, 8, 9};
            int[] expectedSolution = new[] {1, 4, 9, 25, 36, 64, 81};
            var sut = new SortedSquaredArray();
            var solution = sut.Solution2(array);
            solution.Should().BeEquivalentTo(expectedSolution);
        }

        [Test]
        public void TestCase2_Solution2()
        {
            int[] array = new[] {-9, -5, -2, 1, 3, 6, 8};
            int[] expectedSolution = new[] {1, 4, 9, 25, 36, 64, 81};
            var sut = new SortedSquaredArray();
            var solution = sut.Solution2(array);
            solution.Should().BeEquivalentTo(expectedSolution);
        }
    }
}
