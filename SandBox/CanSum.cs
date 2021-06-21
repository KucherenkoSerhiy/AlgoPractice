namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CanSum
    {
        public static bool Solution1(int n, int[] coins)
        {
            Console.WriteLine(n);
            if (n == 0) return true;
            if (n < 0) return false;

            return coins.Any(coin => Solution1(n-coin, coins));
        }

        public static bool Solution2(int n, int[] coins)
        {
            var memo = new Dictionary<int, bool>();
            return Imm_Solution2(n, coins, ref memo);
        }

        public static bool Imm_Solution2(int n, int[] coins, ref Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(n)) return memo[n];
            if (n == 0)
            {
                memo[n] = true;
                return memo[n];
            }
            else if (n < 0)
            {
                memo[n] = false;
                return memo[n];
            }

            foreach (var coin in coins)
            {
                if (Imm_Solution2(n - coin, coins, ref memo))
                {
                    memo[n] = true;
                    return memo[n];
                }
            }

            memo[n] = false;
            return memo[n];
        }

        // O(n*m) Time | O(n) Space, where n = target value, m = number of coins
        public static bool Solution3(int n, int[] coins)
        {
            int[] ways = new int[n + 1];
            ways[0] = 1;

            foreach (int coin in coins)
                for (int index = coin; index < ways.Length; index++)
                    ways[index] += ways[index - coin];

            return ways[n] > 0;
        }
    }
}
