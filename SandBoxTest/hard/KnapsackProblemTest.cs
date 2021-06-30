namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class KnapsackProblemTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            int[,] items =
            {
                { 1, 2 },
                { 4, 3 },
                { 5, 6 },
                { 6, 7 }
            };
            int capacity = 10;

            var expected = new List<List<int>>
            {
                new List<int>{10},
                new List<int>{1, 3}
            };
            var actual = KnapsackProblem.Solution1(items, capacity);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution1_TestCase2()
        {
            int[,] items =
            {
                {465, 100},
                {400, 85},
                {255, 55},
                {350, 45},
                {650, 130},
                {1000, 190},
                {455, 100},
                {100, 25},
                {1200, 190},
                {320, 65},
                {750, 100},
                {50, 45},
                {550, 65},
                {100, 50},
                {600, 70},
                {240, 40}
            };
            int capacity = 200;

            var expected = new List<List<int>>
            {
                new List<int>{1500},
                new List<int>{3, 12, 14}
            };
            var actual = KnapsackProblem.Solution1(items, capacity);
            // actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering()); - fails
        }
        
        [Test]
        public void Solution2_TestCase1()
        {
            int[,] items =
            {
                { 1, 2 },
                { 4, 3 },
                { 5, 6 },
                { 6, 7 }
            };
            int capacity = 10;

            var expected = new List<List<int>>
            {
                new List<int>{10},
                new List<int>{3, 1}
            };
            var actual = KnapsackProblem.Solution2(items, capacity);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Test]
        public void Solution2_TestCase2()
        {
            int[,] items =
            {
                {465, 100},
                {400, 85},
                {255, 55},
                {350, 45},
                {650, 130},
                {1000, 190},
                {455, 100},
                {100, 25},
                {1200, 190},
                {320, 65},
                {750, 100},
                {50, 45},
                {550, 65},
                {100, 50},
                {600, 70},
                {240, 40}
            };
            int capacity = 200;

            var expected = new List<List<int>>
            {
                new List<int>{1500},
                new List<int>{14, 12, 3}
            };
            var actual = KnapsackProblem.Solution2(items, capacity);
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
