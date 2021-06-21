namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;
    using BT = AlgoExpert.NodeDepths.BinaryTree;

    public class NodeDepthsTest
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
                },
                right = new BT(3)
                {
                    left = new BT(6),
                    right = new BT(7)
                }
            };

            Assert.AreEqual(16, NodeDepths.Solution1(tree));
        }
    }
}
