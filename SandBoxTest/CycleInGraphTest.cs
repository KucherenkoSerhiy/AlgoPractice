namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class CycleInGraphTest
    {
        [Test]
        public void Solution1_TestCase1()
        {
            int[][] edges = 
            {
                new []{ 1, 3 },
                new []{ 2, 3, 4 },
                new []{ 0 },
                new int[0],
                new []{ 2, 5 },
                new int[0]
            };

            var sut = new CycleInGraph();

            Assert.IsTrue(sut.Solution1(edges));
        }

        [Test]
        public void Solution1_TestCase2()
        {
            int[][] edges = 
            {
                new []{ 1, 3 },
                new []{ 2, 3, 4 },
                new int[0],
                new int[0],
                new []{ 5 },
                new int[0]
            };

            var sut = new CycleInGraph();

            Assert.IsFalse(sut.Solution1(edges));
        }

        [Test]
        public void Solution1_TestCase3()
        {
            int[][] edges = 
            {
                new []{ 1, 3 },
                new []{ 2, 3},
                new int [0],
                new int[0],
                new []{ 5 },
                new []{ 4 }
            };

            var sut = new CycleInGraph();

            Assert.IsTrue(sut.Solution1(edges));
        }

        [Test]
        public void Solution1_TestCase4()
        {
            int[][] edges = 
            {
                new []{ 1, 3 },
                new []{ 2, 3},
                new int [0],
                new int[0],
                new []{ 5 },
                new []{ 5 }
            };

            var sut = new CycleInGraph();

            Assert.IsTrue(sut.Solution1(edges));
        }
    }
}
