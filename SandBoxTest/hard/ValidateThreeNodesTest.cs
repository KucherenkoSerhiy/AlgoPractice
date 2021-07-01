namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ValidateThreeNodesTest
    {
        [Test]
        public void TestCase1()
        {
            var nodeOne = new ValidateThreeNodes.BST(5)
            {
                right = new ValidateThreeNodes.BST(7)
                {
                    left = new ValidateThreeNodes.BST(6),
                    right = new ValidateThreeNodes.BST(8)
                }
            };
            var nodeThree = new ValidateThreeNodes.BST(3);
            var nodeTwo = new ValidateThreeNodes.BST(2)
            {
                left = new ValidateThreeNodes.BST(1)
                {
                    left = new ValidateThreeNodes.BST(0)
                },
                right = new ValidateThreeNodes.BST(4)
                {
                    left = nodeThree
                }
            };
            var bst = nodeOne;
            bst.left = nodeTwo;

            var sut = new ValidateThreeNodes();
            Assert.IsTrue(sut.Solution(nodeOne, nodeTwo, nodeThree));
        }
    }
}
