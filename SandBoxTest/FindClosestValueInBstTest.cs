namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;
    using BST = AlgoExpert.FindClosestValueInBst.BST;

    public class FindClosestValueInBstTest
    {
        [Test]
        public void TestCase1()
        {
            var tree = new BST(10)
            {
                left = new BST(5)
                {
                    left = new BST(2)
                    {
                        left = new BST(1)
                    },
                    right = new BST(5)
                },
                right = new BST(15)
                {
                    left = new BST(13)
                    {
                        right = new BST(14)
                    },
                    right = new BST(22)
                }

            };
            int target = 12;
            Assert.AreEqual(13, FindClosestValueInBst.Solution1(tree, target));
            Assert.AreEqual(13, FindClosestValueInBst.Solution2(tree, target));
        }
    }
}
