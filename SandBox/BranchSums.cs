using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public static class BranchSums
    {
        // O(n) Time | O(n) Space
        public static List<int> Solution1(BinaryTree root) {
            List<int> sums = new List<int>();
            
            if (root.left == null & root.right == null)
            {
                // leaf node case: just return own value
                sums.Add(root.value);
            }
            else
            {
                // non-leaf node case

                // append sums from left branch if exists
                if (root.left != null)
                    sums.AddRange(Solution1(root.left));
            
                // append sums from right branch if exists
                if (root.right != null)
                    sums.AddRange(Solution1(root.right));

                // add own value
                for (int i = 0; i < sums.Count; i++)
                    sums[i] += root.value;
            }

            return sums;
        }

        public class BinaryTree {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value) {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }
    }
}
