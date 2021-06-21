namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveIslandsTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            int[][] matrix =
            {
                new []{1, 0, 0, 0, 0, 0},
                new []{0, 1, 0, 1, 1, 1},
                new []{0, 0, 1, 0, 1, 0},
                new []{1, 1, 0, 0, 1, 0},
                new []{1, 0, 1, 1, 0, 0},
                new []{1, 0, 0, 0, 0, 1}
            };

            int[][] expected =
            {
                new []{1, 0, 0, 0, 0, 0},
                new []{0, 0, 0, 1, 1, 1},
                new []{0, 0, 0, 0, 1, 0},
                new []{1, 1, 0, 0, 1, 0},
                new []{1, 0, 0, 0, 0, 0},
                new []{1, 0, 0, 0, 0, 1}
            };

            var sut = new RemoveIslands();

            var solution = sut.Solution1(matrix);

            solution.Should().BeEquivalentTo(expected);
        }
        
        [Test]
        public void Solution1_TestCase2()
        {
            int[][] matrix =
            {
                new []{1, 1, 1, 1, 1},
                new []{1, 0, 0, 0, 1},
                new []{1, 0, 1, 0, 1},
                new []{1, 0, 0, 0, 1},
                new []{1, 0, 1, 0, 1},
                new []{1, 0, 1, 0, 1},
                new []{1, 0, 1, 1, 1},
                new []{1, 0, 1, 0, 1}
            };

            int[][] expected =
            {
                new []{1, 1, 1, 1, 1},
                new []{1, 0, 0, 0, 1},
                new []{1, 0, 0, 0, 1},
                new []{1, 0, 0, 0, 1},
                new []{1, 0, 1, 0, 1},
                new []{1, 0, 1, 0, 1},
                new []{1, 0, 1, 1, 1},
                new []{1, 0, 1, 0, 1}
            };

            var sut = new RemoveIslands();

            var solution = sut.Solution1(matrix);

            solution.Should().BeEquivalentTo(expected);
        }
    }
}
