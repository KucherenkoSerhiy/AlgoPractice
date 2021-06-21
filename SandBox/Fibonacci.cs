namespace AlgoExpert
{
    using System.Collections.Generic;

    public class Fibonacci
    {
        public static int Solution1(int n)
        {
            if (n == 0 || n == 1) return 1;
            return Solution1(n - 1) + Solution1(n - 2);
        }

        public static long Solution2(int n)
        {
            var memo = new Dictionary<int, long>();
            var solution = Imm_Solution2(n, ref memo);
            return solution;
        }

        public static long Imm_Solution2(int n, ref Dictionary<int, long> memo)
        {
            if (memo.ContainsKey(n)) return memo[n];
            bool baseCase = n == 0 || n == 1;

            memo[n] = baseCase ? 1 : Imm_Solution2(n - 1, ref memo) + Imm_Solution2(n - 2, ref memo);
            return memo[n];
        }

        // O(n) Time | O(n) Space, where n = input value
        public static long Solution3(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            long[] table = new long[n + 1];
            table[1] = 1;

            for (int i = 2; i < table.Length; i++)
                table[i] = table[i - 1] + table[i - 2];

            return table[n];
        }
    }
}
