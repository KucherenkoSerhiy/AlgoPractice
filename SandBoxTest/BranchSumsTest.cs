namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;
    using BT = AlgoExpert.BranchSums.BinaryTree;

    public class BranchSumsTest
    {
        [Test]
        public void TestCase1()
        {
            BT tree = new BT(1)
            {
                left = new BT(2)
                {
                    left = new BT(4)
                    {
                        left = new BT(8),
                        right = new BT(9)
                    },
                    right = new BT(5)
                    {
                        left = new BT(10)
                    }
                },
                right = new BT(3)
                {
                    left = new BT(6),
                    right = new BT(7)
                }
            };

            List<int> expected = new List<int>{15, 16, 18, 10, 11};
            List<int> actual = BranchSums.Solution1(tree);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
