namespace AlgoExpert.hard
{
    public class ValidateThreeNodes
    {
        public class BST {
            public int value;
            public BST left = null;
            public BST right = null;

            public BST(int value) {
                this.value = value;
            }
        }

        // O(d) Time | O(1) Space, where d = depth of the tree
        public bool Solution(BST nodeOne, BST nodeTwo, BST nodeThree)
        {
            bool isValid = this.Validate(nodeOne, nodeTwo, nodeThree);
            if (!isValid)
                isValid = this.Validate(nodeThree, nodeTwo, nodeOne);
            return isValid;
        }

        private bool Validate(BST nodeOne, BST nodeTwo, BST nodeThree)
        {
            var currentNode = nodeOne;
            this.SearchNode(ref currentNode, nodeTwo);

            if (currentNode != null)
                this.SearchNode(ref currentNode, nodeThree);
            return currentNode == nodeThree;
        }

        private void SearchNode(ref BST currentNode, BST targetNode)
        {
            while (currentNode != null && currentNode != targetNode)
            {
                currentNode = targetNode.value < currentNode.value ? currentNode.left : currentNode.right;
            }
        }
    }
}
