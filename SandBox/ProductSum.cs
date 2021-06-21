using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public static class ProductSum
    {
        // O(n) Time | O(n) Space
        public static int Solution1(List<object> array)
        {
            return Imm_Solution1(array, 1, 1);
        }

        private static int Imm_Solution1(List<object> array, int depth, int depthMultiplier)
        {
            int sum = 0;
            foreach (object o in array)
            {
                if (o is int)
                    sum += (int) o * depthMultiplier;
                else if (o is List<object>)
                    sum += Imm_Solution1((List<object>) o, depth + 1, depthMultiplier * (depth + 1));

            }

            return sum;
        }
    }
}
