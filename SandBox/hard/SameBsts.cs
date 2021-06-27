namespace AlgoExpert.hard
{
    using System.Collections.Generic;
    using System.Linq;

    public class SameBsts
    {
        #region Solution 1

        private struct StackValue
        {
            public int Current { get; set; }
            public int CurrentIndexOne { get; set; }
            public int CurrentIndexTwo { get; set; }
            public int Left { get; set; }
            public int Right { get; set; }
        }

        // O(n^2) Time | O(n) Space, where n = length of the array
        public static bool Solution1(List<int> arrayOne, List<int> arrayTwo)
        {
            if (arrayOne.Count != arrayTwo.Count) return false;
            if (arrayOne.Count == 0) return true;
            if (arrayOne[0] != arrayTwo[0]) return false;

            int numbersChecked = 1; // already checked the first value
            var stack = new Stack<StackValue>();
            stack.Push(new StackValue
            {
                Current = arrayOne[0],
                CurrentIndexOne = 0,
                CurrentIndexTwo = 0,
                Left = int.MinValue,
                Right = int.MaxValue
            });

            while (numbersChecked < arrayOne.Count)
            {
                var stackValue = stack.Pop();
                GetNextSmallerAndBigger(arrayOne, stackValue, stackValue.CurrentIndexOne,
                    out var nextSmallerOne, out var nextBiggerOne,
                    out var nextSmallerOneIndex, out var nextBiggerOneIndex);
                GetNextSmallerAndBigger(arrayTwo, stackValue, stackValue.CurrentIndexTwo,
                    out var nextSmallerTwo, out var nextBiggerTwo,
                    out var nextSmallerTwoIndex, out var nextBiggerTwoIndex);

                if (nextSmallerOne != nextSmallerTwo)
                    return false;
                else if (nextSmallerOne != null)
                {
                    stack.Push(new StackValue
                    {
                        Current = nextSmallerOne.Value,
                        CurrentIndexOne = nextSmallerOneIndex,
                        CurrentIndexTwo = nextSmallerTwoIndex,
                        Left = stackValue.Left,
                        Right = stackValue.Current
                    });
                    numbersChecked ++;
                }

                if (nextBiggerOne != nextBiggerTwo)
                    return false;
                else if (nextBiggerOne != null)
                {
                    stack.Push(new StackValue
                    {
                        Current = nextBiggerOne.Value,
                        CurrentIndexOne = nextBiggerOneIndex,
                        CurrentIndexTwo = nextBiggerTwoIndex,
                        Left = stackValue.Current,
                        Right = stackValue.Right
                    });
                    numbersChecked ++;
                }
            }

            return true;
        }

        private static void GetNextSmallerAndBigger(List<int> array, StackValue stackValue, int currentIndex,
            out int? nextSmaller, out int? nextBigger, out int nextSmallerIndex, out int nextBiggerIndex)
        {
            nextSmaller = null;
            nextBigger = null;
            nextSmallerIndex = -1;
            nextBiggerIndex = -1;
            int i = currentIndex + 1;
            while (i < array.Count && (nextSmaller == null || nextBigger == null))
            {
                if (nextSmaller == null && array[i] <= stackValue.Current && array[i] > stackValue.Left)
                {
                    nextSmaller = array[i];
                    nextSmallerIndex = i;
                }

                if (nextBigger == null && array[i] > stackValue.Current && array[i] <= stackValue.Right)
                {
                    nextBigger = array[i];
                    nextBiggerIndex = i;
                }

                i++;
            }
        }

        #endregion

        // O(n^2) Time | O(n*d) Space, where n = length of the array and d = depth of the tree represented by the array
        public static bool Solution2(List<int> arrayOne, List<int> arrayTwo)
        {
            if (arrayOne.Count != arrayTwo.Count) return false;
            if (arrayOne.Count == 0) return true;

            var first = arrayOne[0];
            if (first != arrayTwo[0]) return false;

            arrayOne.RemoveAt(0);
            arrayTwo.RemoveAt(0);
            var smallersOne = arrayOne.Where(x => x < first).ToList();
            var biggersOrEqualsOne = arrayOne.Where(x => x >= first).ToList();

            var smallersTwo = arrayTwo.Where(x => x < first).ToList();
            var biggersOrEqualsTwo = arrayTwo.Where(x => x >= first).ToList();

            var equalSmallers = Solution2(smallersOne, smallersTwo);
            var equalBiggers = Solution2(biggersOrEqualsOne, biggersOrEqualsTwo);

            return equalSmallers && equalBiggers;
        }
    }
}
