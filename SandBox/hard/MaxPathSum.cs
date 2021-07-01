namespace AlgoExpert.hard
{
    using System;

    public class MaxPathSum
    {
        // O(n) Time | O(log(n)) Space, where n = number of nodes
        public static int Solution(BinaryTree tree)
        {
            var subtreeMaxSum = int.MinValue;
            var currentNodeSum = SubtreeMaxPathSum(tree, ref subtreeMaxSum);
            return Math.Max(currentNodeSum, subtreeMaxSum);
        }

        private static int SubtreeMaxPathSum(BinaryTree tree, ref int subtreeMaxSum)
        {
            if (tree == null) return 0;
            var leftSum = SubtreeMaxPathSum(tree.left, ref subtreeMaxSum);
            var rightSum = SubtreeMaxPathSum(tree.right, ref subtreeMaxSum);

            var currentNodeSum = tree.value + (leftSum > 0 ? leftSum : 0) 
                                            + (rightSum > 0 ? rightSum : 0);
            subtreeMaxSum = Math.Max(currentNodeSum, subtreeMaxSum);

            var subtreeSum = Math.Max(leftSum, rightSum);
            if (subtreeSum < 0) subtreeSum = 0;
            return tree.value + subtreeSum;
        }

        public class BinaryTree {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value) {
                this.value = value;
            }
        }
    }
}
