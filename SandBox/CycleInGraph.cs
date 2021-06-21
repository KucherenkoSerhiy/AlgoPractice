namespace AlgoExpert
{
    using System;
    using System.Linq;

    public class CycleInGraph
    {
        public bool Solution1(int[][] edges)
        {
            bool[] visited = new bool[edges.Length];
            bool[] inStack = new bool[edges.Length];

            bool hasCycle = false;
            while (!hasCycle && !visited.All(x => x))
            {
                int currentNode = 0;
                while (visited[currentNode])
                    currentNode ++;
                hasCycle = this.Imm_CycleInGraph(edges, ref visited, ref inStack, currentNode);
            }

            return hasCycle;
        }

        private bool Imm_CycleInGraph(int[][] edges, ref bool[] visited, ref bool[] inStack, int currentNode)
        {
            if (visited[currentNode]) return inStack[currentNode];

            visited[currentNode] = true;
            inStack[currentNode] = true;

            foreach (int edge in edges[currentNode])
            {
                bool hasCycle = this.Imm_CycleInGraph(edges, ref visited, ref inStack, edge);
                if (hasCycle) return true;
            }

            inStack[currentNode] = false;

            return false;
        }
    }
}
