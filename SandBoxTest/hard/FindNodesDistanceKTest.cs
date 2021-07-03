namespace AlgoExpertTest.hard
{
    using System.Collections.Generic;
    using AlgoExpert.hard;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class FindNodesDistanceKTest
    {
        [Test]
        public void TestCase1()
        {
            var tree = new FindNodesDistanceK.BinaryTree(1)
            {
                left = new FindNodesDistanceK.BinaryTree(2)
                {
                    left = new FindNodesDistanceK.BinaryTree(4),
                    right = new FindNodesDistanceK.BinaryTree(5)
                },
                right = new FindNodesDistanceK.BinaryTree(3)
                {
                    right = new FindNodesDistanceK.BinaryTree(6)
                    {
                        left = new FindNodesDistanceK.BinaryTree(7),
                        right = new FindNodesDistanceK.BinaryTree(8)
                    }
                }
            };
            int target = 3;
            int k = 2;
            var expected = new List<int> {2, 7, 8};
            var sut = new FindNodesDistanceK();
            var actual = sut.Solution(tree, target, k);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
