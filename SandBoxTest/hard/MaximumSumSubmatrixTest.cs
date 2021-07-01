namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MaximumSumSubmatrixTest
    {
        [Test]
        public void TestCase1()
        {
            int[,] matrix = 
            {
                { 5, 3, -1, 5},
                { -7, 3, 7, 4},
                { 12, 8, 0, 0},
                { 1, -8, -8, 2}
            };
            int size = 2;
            int expected = 18;
            var sut = new MaximumSumSubmatrix();
            int actual = sut.Solution1(matrix, size);
            Assert.AreEqual(expected, actual);
        }
    }
}
