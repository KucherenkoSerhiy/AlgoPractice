namespace AlgoExpert
{
    using System.Collections.Generic;

    public class MinHeap {
        public List<int> heap = new List<int>();

        public MinHeap(List<int> array) {
            heap = buildHeap(array);
        }

        // O(n)) Time | O(1) space
        public List<int> buildHeap(List<int> array)
        {
            int lastNodeIndex = array.Count;
            int lastParentNodeIndex = (lastNodeIndex - 1) / 2;

            for (int index = lastParentNodeIndex; index >= 0; index--)
                this.siftDown(index, 0, array);
            
            return array;
        }

        // O(log(n)) Time | O(1) Space
        public void siftDown(int currentIdx, int endIdx, List<int> heap)
        {
            int leftChildIndex = 2 * currentIdx + 1;
            int rightChildIndex = 2 * currentIdx + 2;

            while (leftChildIndex < heap.Count && heap[currentIdx] > heap[leftChildIndex]
                || rightChildIndex < heap.Count && heap[currentIdx] > heap[rightChildIndex])
            {
                int minChildIndex = rightChildIndex < heap.Count && heap[rightChildIndex] < heap[leftChildIndex]
                    ? rightChildIndex : leftChildIndex;
                Swap(heap, currentIdx, minChildIndex);
                currentIdx = minChildIndex;
                leftChildIndex = 2 * currentIdx + 1;
                rightChildIndex = 2 * currentIdx + 2;
            }
        }

        // O(log(n)) Time | O(1) Space
        public void siftUp(int currentIdx, List<int> heap)
        {
            int parentIndex = (currentIdx - 1) / 2;
            while (parentIndex >= 0 && heap[currentIdx] < heap[parentIndex])
            {
                Swap(heap, currentIdx, parentIndex);
                currentIdx = parentIndex;
                parentIndex = (currentIdx - 1) / 2;
            }
        }

        public int Peek()
        {
            return this.heap[0];
        }

        public int Remove()
        {
            int valueToRemove = this.heap[0];

            int lastIndex = this.heap.Count - 1;
            Swap(this.heap, 0, lastIndex);
            this.heap.RemoveAt(lastIndex);
            this.siftDown(0, lastIndex, this.heap);

            return valueToRemove;
        }

        public void Insert(int value) {
            this.heap.Add(value);
            int currentIndex = this.heap.Count - 1;
            this.siftUp(currentIndex, this.heap);
        }

        private static void Swap(List<int> heap, int index1, int index2)
        {
            int temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }
}
