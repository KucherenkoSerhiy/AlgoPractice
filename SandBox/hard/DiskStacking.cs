namespace AlgoExpert.hard
{
    using System;
    using System.Collections.Generic;

    public static class DiskStacking
    {
        // O(n^2) Time | O(n) Space, where n = length of the array
        public static List<int[]> Solution(List<int[]> disks) {
            disks.Sort((a, b) => a[2] - b[2]);
            var diskStacks = new List<int[]>();
            for (int i = 0; i < disks.Count; i++)
            {
                var diskStack = new int[3];
                Array.Copy(disks[i], diskStack, 3);
                diskStacks.Add(diskStack);
            }

            for (int i = 1; i < disks.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (diskStacks[i][2] < diskStacks[j][2] + disks[i][2] &&
                        disks[i][0] > disks[j][0] && disks[i][1] > disks[j][1] && disks[i][2] > disks[j][2])
                    {
                        diskStacks[i][0] = disks[i][0] + diskStacks[j][0];
                        diskStacks[i][1] = disks[i][1] + diskStacks[j][1];
                        diskStacks[i][2] = disks[i][2] + diskStacks[j][2];
                    }
                }
            }

            var solution = new List<int[]>();
            int currentSolutionIndex = 0;
            for (int i = 0; i < diskStacks.Count; i++)
            {
                if (diskStacks[i][2] > diskStacks[currentSolutionIndex][2])
                    currentSolutionIndex = i;
            }

            solution.Add(disks[currentSolutionIndex]);
            var nextDiskStackHeight = diskStacks[currentSolutionIndex][2] - disks[currentSolutionIndex][2];
            var nextDiskStackIndex = diskStacks.FindIndex(x => x[2] == nextDiskStackHeight);
            while (nextDiskStackIndex >= 0)
            {
                solution.Add(disks[nextDiskStackIndex]);
                nextDiskStackHeight = diskStacks[nextDiskStackIndex][2] - disks[nextDiskStackIndex][2];
                nextDiskStackIndex = diskStacks.FindIndex(x => x[2] == nextDiskStackHeight);
            }
            solution.Reverse();

            return solution;
        }
    }
}
