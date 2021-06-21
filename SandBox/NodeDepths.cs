namespace AlgoExpert
{
    public static class NodeDepths
    {
        // O(n) Time | O(n) Space
        public static int Solution1(BinaryTree root) {
            return Imm_Solution1(root, 0);
        }

        private static int Imm_Solution1(BinaryTree root, int currentDepth)
        {
            int depthSum = currentDepth;
            if (root.left != null)
                depthSum += Imm_Solution1(root.left, currentDepth + 1);
            if (root.right != null)
                depthSum += Imm_Solution1(root.right, currentDepth + 1);
            return depthSum;
        }

        public class BinaryTree {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value) {
                this.value = value;
                left = null;
                right = null;
            }
        }
    }
}
