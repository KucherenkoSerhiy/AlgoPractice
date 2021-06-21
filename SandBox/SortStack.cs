using System.Collections.Generic;

namespace AlgoExpert
{
    using System;
    using System.Linq;

    public class SortStack
    {
        // O(n^2) Time | O(n) Space, where n = length of the stack
        public List<int> Solve(List<int> stack) {
            if (stack.Count <= 1) return stack;
            for (int i = 0; i < stack.Count; i++)
            {
                int last = stack.Pop();
                int min = this.Imm_SortStack(ref stack, last);
                stack.Push(min);
            }
            
            return stack;
        }
	
        // O(n) Time | O(n) Space, where n = length of the stack
        private int Imm_SortStack(ref List<int> stack, int prev){
            int current = stack.Pop();
		
            int currentMin = Math.Min(current, prev);
            int currentMax = Math.Max(current, prev);

            int max;
            if (stack.Count == 0){
                stack.Push(currentMin);
                max = currentMax;
            }
            else{
                int childMin = this.Imm_SortStack(ref stack, currentMin);
			
                int min = Math.Min(currentMax, childMin);
                max = Math.Max(currentMax, childMin);
			
                stack.Push(min);
            }
		
            return max;
        }
    }
}

public static class ListStackExtensions{
    public static int Pop(this List<int> stack){
        int value = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return value;
    }
	
    public static void Push(this List<int> stack, int value){
        stack.Add(value);
    }
}