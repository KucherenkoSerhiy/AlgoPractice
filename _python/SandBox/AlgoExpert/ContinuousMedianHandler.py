class ContinuousMedianHandler:
    lowerHeapType = "max_heap"
    greaterHeapType = "min_heap"

    def __init__(self):
        self.median = None
        self.lower_half = []
        self.greater_half = []

    # O(n*log(n)) Time | O(n) Space, where n = number of inserted numbers
    def insert(self, number):
        if len(self.lower_half) == 0:
            self.lower_half.append(number)
        elif len(self.greater_half) == 0:
            self.greater_half.append(number)
        else:
            if number <= self.lower_half[0]:
                self.insertIntoHeap(number, self.lower_half, ContinuousMedianHandler.lowerHeapType)
            else:
                self.insertIntoHeap(number, self.greater_half, ContinuousMedianHandler.greaterHeapType)
        self.rebalance()
        self.updateMedian()

    def getMedian(self):
        return self.median

    def insertIntoHeap(self, number, heap, heap_type):
        heap.append(number)
        current_index = len(heap) - 1
        parent_index = (current_index - 1) // 2
        should_swap = self.shouldSwap(current_index, heap, heap_type, parent_index)
        while current_index > 0 and should_swap:
            self.swap(heap, current_index, parent_index)
            current_index = parent_index
            parent_index = (current_index - 1) // 2
            should_swap = self.shouldSwap(current_index, heap, heap_type, parent_index)

    def rebalance(self):
        if abs(len(self.lower_half) - len(self.greater_half)) < 2:
            return
        elif len(self.lower_half) > len(self.greater_half):
            self.insertIntoHeap(self.lower_half[0], self.greater_half, ContinuousMedianHandler.greaterHeapType)
            self.removeFirst(self.lower_half, ContinuousMedianHandler.lowerHeapType)
        elif len(self.greater_half) > len(self.lower_half):
            self.insertIntoHeap(self.greater_half[0], self.lower_half, ContinuousMedianHandler.lowerHeapType)
            self.removeFirst(self.greater_half, ContinuousMedianHandler.greaterHeapType)

    def updateMedian(self):
        if len(self.lower_half) > len(self.greater_half):
            self.median = self.lower_half[0]
        elif len(self.lower_half) < len(self.greater_half):
            self.median = self.greater_half[0]
        else:
            self.median = (self.lower_half[0] + self.greater_half[0]) / 2

    def removeFirst(self, heap, heap_type):
        # swap first and last
        self.swap(heap, 0, len(heap) - 1)
        # safely remove last
        del heap[-1]
        # sift down first
        current_index = 0
        first_child_index = 1
        last_child_index = 2
        while ((first_child_index < len(heap) and self.shouldSwap(first_child_index, heap, heap_type, current_index))
               or (last_child_index < len(heap) and self.shouldSwap(last_child_index, heap, heap_type, current_index))):
            if last_child_index >= len(heap) or (heap_type == ContinuousMedianHandler.lowerHeapType and heap[first_child_index] > heap[last_child_index] \
                    or heap_type == ContinuousMedianHandler.greaterHeapType and heap[first_child_index] < heap[last_child_index]):
                self.swap(heap, first_child_index, current_index)
                current_index = first_child_index
            else:
                self.swap(heap, last_child_index, current_index)
                current_index = last_child_index
            first_child_index = current_index * 2 + 1
            last_child_index = current_index * 2 + 2

    def shouldSwap(self, current_index, heap, heap_type, parent_index):
        if current_index < 0 or current_index >= len(heap) \
                or parent_index < 0 or parent_index >= len(heap):
            return False
        lower_heap_case = heap_type == ContinuousMedianHandler.lowerHeapType and heap[current_index] > heap[parent_index]
        greater_heap_case = heap_type == ContinuousMedianHandler.greaterHeapType and heap[current_index] < heap[parent_index]

        return lower_heap_case or greater_heap_case

    def swap(self, heap, current_index, parent_index):
        temp = heap[parent_index]
        heap[parent_index] = heap[current_index]
        heap[current_index] = temp
