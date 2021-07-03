namespace AlgoExpert.hard
{
    using System.Collections.Generic;

    public class FindNodesDistanceK
    {
        public class BinaryTree {
            public int value;
            public BinaryTree left = null;
            public BinaryTree right = null;

            public BinaryTree(int value) {
                this.value = value;
            }
        }

        // O(V + E) Time | O(V + E), where V = number of vertices and E = number of edges in the tree
        // O(n) Time | O(n), where n = number of nodes in the tree
        public List<int> Solution(BinaryTree tree, int target, int k)
        {
            var parents = new Dictionary<int, BinaryTree>();
            this.GetParents(tree, null, ref parents);

            var visited = new HashSet<int>();
            var bfsQueue = new Queue<(BinaryTree node, int distance)>();
            var targetNode = this.GetTargetNode(tree, target);
            bfsQueue.Enqueue((targetNode, 0));

            var solution = new List<int>();
            while (bfsQueue.Count > 0)
            {
                var currentNode = bfsQueue.Dequeue();
                var currentValue = currentNode.node.value;
                var currentDistance = currentNode.distance;

                if (currentDistance == k)
                    solution.Add(currentValue);
                visited.Add(currentValue);

                if (currentNode.node.left != null && !visited.Contains(currentNode.node.left.value))
                    bfsQueue.Enqueue((currentNode.node.left, currentDistance + 1));
                if (currentNode.node.right != null && !visited.Contains(currentNode.node.right.value))
                    bfsQueue.Enqueue((currentNode.node.right, currentDistance + 1));
                if (parents[currentValue] != null && !visited.Contains(parents[currentValue].value))
                    bfsQueue.Enqueue((parents[currentValue], currentDistance + 1));
            }

            return solution;
        }

        private BinaryTree GetTargetNode(BinaryTree node, int target)
        {
            if (node == null) return null;
            if (node.value == target) return node;

            var left = this.GetTargetNode(node.left, target);
            var right = this.GetTargetNode(node.right, target);

            return left ?? right;
        }

        private void GetParents(BinaryTree node, BinaryTree parent, ref Dictionary<int, BinaryTree> parents)
        {
            if (node == null) return;

            parents[node.value] = parent;
            this.GetParents(node.left, node, ref parents);
            this.GetParents(node.right, node, ref parents);
        }
    }
}
