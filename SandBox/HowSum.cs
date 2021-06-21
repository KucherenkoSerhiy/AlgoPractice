namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HowSum
    {
        // O(d^n) Time | O(n) Space, where d = length of array of values and n = target number
        public static int[] Solution1(int target, int[] values)
        {
            var result = new Stack<int>();
            bool hasSolution = Imm_Solution1(target, values, ref result);
            return hasSolution? result.Reverse().ToArray() : null;
        }

        private static bool Imm_Solution1(int target, int[] values, ref Stack<int> result)
        {
            if (target == 0) return true;
            if (target < 0) return false;

            foreach (int value in values)
            {
                result.Push(value);
                bool hasSolution = Imm_Solution1(target-value, values, ref result);
                if (hasSolution)
                    return true;
                result.Pop();
            }

            return false;
        }

        // O(n) Time | O(n*m) Space, where d = length of array of values and n = target number
        public static int[] Solution2(int target, int[] values)
        {
            var result = new Stack<int>();
            var memo = new Dictionary<int, (bool found, Stack<int> result)>();
            bool hasSolution = Imm_Solution2(target, values, ref result, ref memo);
            return hasSolution? result.Reverse().ToArray() : null;
        }

        private static bool Imm_Solution2(int target, int[] values, ref Stack<int> result, ref Dictionary<int, (bool found, Stack<int> result)> memo)
        {
            if (memo.ContainsKey(target))
            {
                bool found = memo[target].found;
                if (found)
                    foreach (int value in memo[target].result)
                    {
                        result.Push(value);
                    }

                return found;
            }
            if (target == 0)
            {
                memo[target] = (true, result);
                return true;
            }

            if (target < 0)
            {
                memo[target] = (false, result);
                return false;
            }

            foreach (int value in values)
            {
                result.Push(value);
                bool hasSolution = Imm_Solution2(target-value, values, ref result, ref memo);
                if (hasSolution)
                {
                    memo[target] = (true, result);
                    return true;
                }
                result.Pop();
            }

            memo[target] = (false, result);
            return false;
        }
        

        // O(n*m) Time | O(n) Space, where n = target value, m = number of coins
        public static List<int[]>[] Solution3(int n, int[] coins)
        {
            List<int[]>[] ways = new List<int[]>[n + 1];
            for (int i = 0; i < ways.Length; i++)
                ways[i] = new List<int[]>();
            ways[0].Add(new int[0]);

            foreach (int coin in coins)
                for (int index = coin; index < ways.Length; index++)
                {
                    var newWays = new List<int[]>();
                    foreach (var way in ways[index-coin])
                    {
                        int[] newWay = new int[way.Length + 1];
                        newWay[0] = coin;
                        Array.Copy(way, 0, newWay, 1, way.Length);
                        newWays.Add(newWay);
                    }

                    ways[index].AddRange(newWays);
                }
                    

            return ways;
        }
    }
}
