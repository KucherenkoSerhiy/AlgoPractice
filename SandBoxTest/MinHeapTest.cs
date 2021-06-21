namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class MinHeapTest
    {
        [Test]
        public void TestCase1()
        {
            var array = new List<int> {48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, 8, 41};
            
            var minHeap = new MinHeap(array);
            // Assert
            minHeap.Insert(76);
            // Assert
            minHeap.Peek();
            // Assert
            minHeap.Remove();
            // Assert
            minHeap.Peek();
            // Assert
            minHeap.Remove();
            // Assert
            minHeap.Peek();
            // Assert
            minHeap.Insert(87);
            // Assert
        }
    }
}
