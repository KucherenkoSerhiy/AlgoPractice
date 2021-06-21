namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MinMaxStackTest
    {
        [Test]
        public void TestCase1()
        {
            var sut = new MinMaxStack();
            sut.Push(5);
            Assert.AreEqual(5, sut.GetMin());
            Assert.AreEqual(5, sut.GetMax());
            Assert.AreEqual(5, sut.Peek());

            sut.Push(7);
            Assert.AreEqual(5, sut.GetMin());
            Assert.AreEqual(7, sut.GetMax());
            Assert.AreEqual(7, sut.Peek());

            sut.Push(2);
            Assert.AreEqual(2, sut.GetMin());
            Assert.AreEqual(7, sut.GetMax());
            Assert.AreEqual(2, sut.Peek());

            Assert.AreEqual(2, sut.Pop());
            Assert.AreEqual(7, sut.Pop());

            Assert.AreEqual(5, sut.GetMin());
            Assert.AreEqual(5, sut.GetMax());
            Assert.AreEqual(5, sut.Peek());
        }
    }
}
