using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public static class FindClosestValueInBst
    {
        // O(log(n)) Time (Worst O(n)) | O(log(n)) Space (Worst O(n))
        public static int Solution1(BST tree, int target)
        {
            int? sonValue = null;
            if (tree.value == target) {return tree.value;}
            else if (tree.value > target)
            {
                if (tree.left == null) return tree.value;
                sonValue = Solution1(tree.left, target);
            }
            else if (tree.value < target)
            {
                if (tree.right == null) return tree.value;
                sonValue = Solution1(tree.right, target);
            }
            
            int ownDistance = Math.Abs(target - tree.value);
            int sonDistance = Math.Abs(target - sonValue.Value);

            if (ownDistance <= sonDistance)
                return tree.value;
            else return sonValue.Value;
        }

        // O(log(n)) Time (Worst O(n)) | O(log(n)) Space (Worst O(n))
        public static int Solution2(BST tree, int target)
        {
            var closest = tree.value;
            if (closest == target) return closest;
            Imm_Solution2(tree, target, ref closest);
            return closest;
        }

        private static void Imm_Solution2(BST tree, int target, ref int closest)
        {
            int actualDistance = Math.Abs(target - tree.value);
            int closestDistance = Math.Abs(target - closest);
            if (actualDistance < closestDistance)
                closest = tree.value;

            if (tree.value == target) return;
            if (tree.value < target)
            {
                if (tree.right != null)
                    Imm_Solution2(tree.right, target, ref closest);
            }
            if (tree.value > target)
            {
                if (tree.left != null)
                    Imm_Solution2(tree.left, target, ref closest);
            }
        }

        public class BST {
            public int value;
            public BST left;
            public BST right;

            public BST(int value) {
                this.value = value;
            }
        }
    }
}
