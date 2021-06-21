namespace AlgoExpert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxStack
    {
        // each value is a triplet made of:
        //     current value
        //     current min value
        //     current max value

        private readonly List<int[]> stack;

        public MinMaxStack()
        {
            this.stack = new List<int[]>();
        }

        public int Peek()
        {
            return this.stack[this.stack.Count - 1][0];
        }

        public int Pop()
        {
            var lastIndex = this.stack.Count - 1;
            var lastElement = this.stack[lastIndex];
            this.stack.RemoveAt(lastIndex);
            return lastElement[0];
        }


        public void Push(int number)
        {
            if (!this.stack.Any())
                this.stack.Add(new []{number, number, number});
            else
            {
                var lastIndex = this.stack.Count - 1;
                var lastElement = this.stack[lastIndex];
                var min = Math.Min(lastElement[1], number);
                var max = Math.Max(lastElement[2], number);
                this.stack.Add(new []{number, min, max});
            }
        }


        public int GetMin() {
            return this.stack[this.stack.Count - 1][1];
        }


        public int GetMax() {
            return this.stack[this.stack.Count - 1][2];
        }
    }
}
