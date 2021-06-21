namespace AlgoExpert
{
    using System;

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        // O(log(n)) Time | O(1) Space
        public BST Insert(int value)
        {
            bool inserted = false;
            BST current = this;

            while (!inserted)
            {
                if (value < current.value)
                {
                    if (current.left == null)
                    {
                        current.left = new BST(value);
                        inserted = true;
                    }
                    else
                        current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = new BST(value);
                        inserted = true;
                    }
                    else
                        current = current.right;
                }
            }

            return this;
        }

        // O(log(n)) Time | O(1) Space
        // O(n) Time | O(1) Space - worst case
        public bool Contains(int value)
        {
            var current = this.Find(value);

            return current != null && current.value == value;
        }

        // O(log(n)) Time | O(1) Space - normal case
        public BST Remove(int value)
        {
            var nodeToRemove = this.Find(value);
            var parent = this.FindParent(value);
            // leaf node case
            if (nodeToRemove.left == null && nodeToRemove.right == null)
            {
                if (parent == null) 
                    return this; // root node case
                if (parent.left?.value == nodeToRemove.value)
                    parent.left = null;
                else
                    parent.right = null;
            }
            // 1 child node case
            else if (nodeToRemove.left == null || nodeToRemove.right == null)
            {
                if (parent == null)
                {
                    if (nodeToRemove.right != null)
                    {
                        nodeToRemove.value = nodeToRemove.right.value;
                        nodeToRemove.right = nodeToRemove.right.right;
                        nodeToRemove.left = nodeToRemove.right.left;
                    }
                    else
                    {
                        nodeToRemove.value = nodeToRemove.left.value;
                        nodeToRemove.right = nodeToRemove.left.right;
                        nodeToRemove.left = nodeToRemove.left.left;
                    }
                }
                else
                {
                    if (parent.left?.value == nodeToRemove.value)
                        parent.left = nodeToRemove.right ?? nodeToRemove.left;
                    else
                        parent.right = nodeToRemove.right ?? nodeToRemove.left;
                }
            }
            // 2 children node case
            else
            {
                // root unhandled
                BST smallestBigger = nodeToRemove.right;
                while (smallestBigger.left != null)
                    smallestBigger = smallestBigger.left;
                if (nodeToRemove.right == smallestBigger)
                    nodeToRemove.right = smallestBigger.right;
                else
                {
                    var smallestBiggerParent = nodeToRemove.FindParent(smallestBigger.value);
                    smallestBiggerParent.left = smallestBigger.right;
                }
                nodeToRemove.value = smallestBigger.value;
            }

            return this;
        }

        private BST Find(int value)
        {
            BST current = this;
            while (current != null && current.value != value)
                current = value < current.value ? current.left : current.right;
            return current;
        }

        private BST FindParent(int value)
        {
            BST current = this;
            BST previous = null;
            while (current != null && current.value != value)
            {
                previous = current;
                current = value < current.value ? current.left : current.right;
            }
            return previous;
        }

    }
}
