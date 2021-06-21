namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class RiverSizesTest
    {
        [Test]
        public void TestCase1_Solution1_ReturnsRiverSizes()
        {
            // Arrange
            int[,] matrix =
            {
                {1, 0, 0, 1, 0 },
                {1, 0, 1, 0, 0 },
                {0, 0, 1, 0, 1 },
                {1, 0, 1, 0, 1 },
                {1, 0, 1, 1, 0 }
            };

            var expected = new List<int>
            {
                1, 2, 2, 2, 5
            };

            // Act
            var actual = RiverSizes.Solution1(matrix);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
        [Test]
        public void TestCase2_Solution1_ReturnsRiverSizes()
        {
            // Arrange
            int[,] matrix =
            {
                
            };

            var expected = new List<int>();

            // Act
            var actual = RiverSizes.Solution1(matrix);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
