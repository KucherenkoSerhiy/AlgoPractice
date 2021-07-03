namespace AlgoExpert.hard
{
    public class DijkstrasAlgorithm
    {
        // O(V*E + V^2) Time | O(V) Space, where V = vertices and E = edges of the graph
        public int[] Solution(int start, int[][][] edges)
        {
            // init data structure
            int[] distances = new int[edges.Length];
            for (int i = 0; i < distances.Length; i++)
                distances[i] = -1;
            distances[start] = 0;

            bool[] visited = new bool[edges.Length];

            int currentVertice = start;

            while (currentVertice != -1)
            {
                // count edges
                foreach (var currentVerticeEdges in edges[currentVertice])
                {
                    var targetVertice = currentVerticeEdges[0];
                    var currentDistance = distances[currentVertice] + currentVerticeEdges[1];
                    if (distances[targetVertice] == -1 || distances[targetVertice] > currentDistance)
                        distances[targetVertice] = currentDistance;
                }

                visited[currentVertice] = true;
                
                // TODO: improvable: use min heap to change this O(V) to O(log(V))
                // select next vertice
                currentVertice = -1;
                var minEdgeDistance = int.MaxValue;
                for (int i = 0; i < distances.Length; i++)
                {
                    if (!visited[i] && distances[i] != -1 && distances[i] < minEdgeDistance)
                    {
                        currentVertice = i;
                        minEdgeDistance = distances[i];
                    }
                }
            }

            return distances;
        }
    }
}
