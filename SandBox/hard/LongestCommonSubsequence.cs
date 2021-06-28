namespace AlgoExpert.hard
{
    using System.Collections.Generic;

    public static class LongestCommonSubsequence
    {
        #region Solution 1

        private struct ValueTuple
        {
            internal List<char> value;
            internal int index;
        }

        // O(n*m) Time | O(n*m) Space, where n and m are length of the arrays
        public static List<char> Solution1(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2)) return new List<char>();

            var commonSubsequences = new List<ValueTuple>();
            foreach (var letter1 in str1)
            {
                for (var index2 = 0; index2 < str2.Length; index2++)
                {
                    var letter2 = str2[index2];
                    if (letter1 == letter2)
                    {
                        bool alreadyAggregated = false;
                        for (var i = 0; i < commonSubsequences.Count; i++)
                        {
                            var commonSubsequence = commonSubsequences[i];
                            if (commonSubsequence.index < index2)
                            {
                                commonSubsequence.value.Add(letter2);
                                commonSubsequence.index = index2;
                                alreadyAggregated = true;
                            }
                        }

                        if (!alreadyAggregated)
                            commonSubsequences.Add(new ValueTuple{index = index2, value = new List<char>{letter2}});
                    }
                }
            }

            return commonSubsequences[commonSubsequences.Count - 1].value;
        }

        #endregion

        #region Solution 2

        private struct TableRegistry
        {
            internal int prevRow;
            internal int prevCol;
            internal int length;
        }

        // O(n*m) Time | O(n*m) Space, where n and m are length of the arrays
        public static List<char> Solution2(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2)) return new List<char>();

            var table = CreateTable(str1, str2);

            for (int row = 1; row < table.Length; row++)
            {
                for (int col = 1; col < table[0].Length; col++)
                {
                    var left = table[row][col - 1];
                    var top = table[row - 1][col];
                    var topLeft = table[row - 1][col - 1];
                    if (str1[row - 1] == str2[col - 1])
                        topLeft.length++;
                        

                    if (topLeft.length > top.length && topLeft.length > left.length)
                    {
                        table[row][col] = new TableRegistry
                        {
                            length = topLeft.length,
                            prevRow = row - 1,
                            prevCol = col - 1
                        };
                    }
                    else if (top.length > left.length)
                    {
                        table[row][col] = new TableRegistry
                        {
                            length = top.length,
                            prevRow = row - 1,
                            prevCol = col
                        };
                    }
                    else
                    {
                        table[row][col] = new TableRegistry
                        {
                            length = left.length,
                            prevRow = row,
                            prevCol = col - 1
                        };
                    }
                }
            }

            var currentRow = table.Length - 1;
            var currentCol = table[0].Length - 1;
            var solution = new List<char>();

            while (currentRow != -1 && currentCol != -1)
            {
                var currentReg = table[currentRow][currentCol];
                if (currentReg.prevRow != -1 && currentReg.prevCol != -1 && 
                    currentReg.length > table[currentReg.prevRow][currentReg.prevCol].length)
                    solution.Add(str1[currentRow - 1]);
                currentRow = currentReg.prevRow;
                currentCol = currentReg.prevCol;
            }

            solution.Reverse();

            return solution;
        }

        private static TableRegistry[][] CreateTable(string str1, string str2)
        {
            var table = new TableRegistry[str1.Length + 1][];
            table[0] = new TableRegistry[str2.Length + 1];
            for (int i = 0; i < table[0].Length; i++)
            {
                table[0][i] = new TableRegistry
                {
                    prevRow = -1,
                    prevCol = -1,
                    length = 0
                };
            }

            for (int i = 1; i < table.Length; i++)
            {
                table[i] = new TableRegistry[str2.Length + 1];
                table[i][0] = new TableRegistry
                {
                    prevRow = -1,
                    prevCol = -1,
                    length = 0
                };
            }

            return table;
        }

        #endregion
    }
}
