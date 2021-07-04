namespace AlgoExpert.hard
{
    using System.Collections.Generic;

    public static class TopologicalSort
    {
        // O(j + d) Time | O(j + d) Space, where j is the number of the jobs and d is the number of the dependencies
        public static List<int> Solution(List<int> jobs, List<int[]> deps)
        {
            var table = new Dictionary<int, (bool processing, bool resolved)>();
            for (int i = 0; i < jobs.Count; i++)
                table.Add(jobs[i], (false, false));
            
            var dependencies = new Dictionary<int, List<int>>();
            foreach (var dependency in deps)
            {
                if (!dependencies.ContainsKey(dependency[1])) 
                    dependencies.Add(dependency[1], new List<int>());
                dependencies[dependency[1]].Add(dependency[0]);
            }

            var solution = new List<int>();
            for (int i = 0; i < table.Count; i++)
                if (!table[jobs[i]].resolved)
                {
                    var cycleDetected = Imm_TopologicalSort(dependencies, ref table, jobs[i], ref solution);
                    if (cycleDetected)
                        return new List<int>();
                }
                    

            return solution;
        }

        private static bool Imm_TopologicalSort(Dictionary<int, List<int>> dependencies,
            ref Dictionary<int, (bool processing, bool resolved)> table,
            int vertex, ref List<int> solution)
        {
            var cycleDetected = false;

            if (table[vertex].processing)
            {
                return true;
            }

            table[vertex] = (true, false); // job/vertex being processed

            if (dependencies.ContainsKey(vertex))
                foreach (var dependency in dependencies[vertex])
                {
                    if (!table[dependency].resolved)
                        cycleDetected = Imm_TopologicalSort(dependencies, ref table, dependency, ref solution);
                    if (cycleDetected)
                        return true;
                }

            table[vertex] = (true, true); // job/vertex resolved
            solution.Add(vertex);

            return false;
        }
    }
}
