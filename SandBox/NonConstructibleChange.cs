using System;

namespace AlgoExpert
{
    public class NonConstructibleChange
    {
        // O(n*log(n) + log(n)^2*K) Time | O(1) Space
        public int Solution1(int[] coins)
        {
            if (coins.Length == 0) return 1;

            Array.Sort(coins);

            bool found = false;
            int candidate = 1;
            while (!found)
            {
                found = !MatchViaSum(coins, candidate);
                    if (!found)
                        candidate++;
            }
            return candidate;
        }

        private static bool MatchViaSum(int[] coins, int candidate)
        {
            int sum = 0;
            int i = coins.Length - 1;
            while (sum != candidate && i >= 0)
            {
                if (sum + coins[i] <= candidate)
                    sum += coins[i];
                i--;
            }
            return sum == candidate;
        }

        // O(n * log(n)) Time | O(1) Space
        public int Solution2(int[] coins)
        {
            Array.Sort(coins);
		
		    int currentCoinSum = 0;
		    for (int i = 0; i < coins.Length; i++){
			    if (coins[i] > currentCoinSum + 1)
				    return currentCoinSum + 1;
			    currentCoinSum += coins[i];
		    }
		    return currentCoinSum + 1;
        }
    }
}
