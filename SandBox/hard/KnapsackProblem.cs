namespace AlgoExpert.hard
{
    using System;
    using System.Collections.Generic;

    public static class KnapsackProblem
    {
        internal struct TableRegistry
        {
            internal int LastAddedElement;
            internal int Sum;
            internal int TotalWeight;
            internal List<int> Elements;
        }

        // O(n^2*c) Time | O(n*c) Space, where n is the length of the array and c is the capacity
        public static List<List<int> > Solution1(int[,] items, int capacity)
        {
            var table = new TableRegistry[capacity + 1];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new TableRegistry
                {
                    LastAddedElement = -1,
                    Sum = 0,
                    TotalWeight = 0,
                    Elements = new List<int>()
                };
            }

            for (int i = 0; i < items.GetLength(0); i++)
            {
                var currentWeight = items[i, 1];
                for (int j = currentWeight; j < table.Length; j++)
                {
                    var valueToAdd = table[j - currentWeight].LastAddedElement < i ? items[i, 0] : 0; // consider new value only if not added
                    var weightToAdd = table[j - currentWeight].LastAddedElement < i ? items[i, 1] : 0; // consider new value only if not added

                    var betterValue = table[j].Sum < table[j - currentWeight].Sum + valueToAdd;
                    var equalValue = table[j].Sum == table[j - currentWeight].Sum + valueToAdd;
                    var betterWeight = table[j].TotalWeight > table[j - currentWeight].TotalWeight + weightToAdd;
                    if (betterValue || equalValue && betterWeight)
                    {
                        table[j].LastAddedElement = i;
                        table[j].Sum = table[j - currentWeight].Sum + valueToAdd;
                        table[j].TotalWeight = table[j - currentWeight].TotalWeight + weightToAdd;
                        table[j].Elements = new List<int>(table[j - currentWeight].Elements);
                        if (valueToAdd > 0)
                            table[j].Elements.Add(i);
                    }
                }
            }

            var solution = new List<List<int>>
            {
                new List<int>{ table[table.Length - 1].Sum},
                table[table.Length - 1].Elements
            };

            return solution;
        }

        // O(n*c) Time | O(n*c) Space, where n is the length of the array and c is the capacity
        public static List<List<int>> Solution2(int[,] items, int capacity)
        {
            if (capacity == 0 || items.Length == 0)
            {
                return new List<List<int>>
                {
                    new List<int>{0},
                    new List<int>()
                };
            }

            var table = new int[items.GetLength(0) + 1, capacity + 1];
            for (int i = 1; i < table.GetLength(0); i++)
            {
                var value = items[i - 1, 0];
                var weght = items[i - 1, 1];
                for (int j = 0; j < weght; j++)
                {
                    table[i, j] = table[i - 1, j];
                }
                for (int j = weght; j < table.GetLength(1); j++)
                {
                    table[i, j] = Math.Max(table[i - 1, j], table[i - 1, j - weght] + value);
                }
            }

            var x = table.GetLength(0) - 1;
            var y = table.GetLength(1) - 1;
            var solution = new List<int>();
            while (table[x, y] != 0)
            {
                if (table[x, y] == table[x - 1, y])
                    x--;
                else
                {
                    solution.Add(x - 1);
                    y -= items[x - 1, 1];
                    x--;
                }
            }

            return new List<List<int>>
            {
                new List<int>{table[table.GetLength(0) - 1, table.GetLength(1) - 1]},
                solution
            };
        }
    }
}
