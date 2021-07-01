namespace AlgoExpertTest.hard
{
    using AlgoExpert.hard;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MaxPathSumTest
    {
        [Test]
        public void TestCase1()
        {
            var tree = new MaxPathSum.BinaryTree(1)
            {
                left = new MaxPathSum.BinaryTree(2)
                {
                    left = new MaxPathSum.BinaryTree(4),
                    right = new MaxPathSum.BinaryTree(5)
                },
                right = new MaxPathSum.BinaryTree(3)
                {
                    left = new MaxPathSum.BinaryTree(6),
                    right = new MaxPathSum.BinaryTree(7)
                }
            };
            var expected = 18;
            var actual = MaxPathSum.Solution(tree);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            var tree = new MaxPathSum.BinaryTree(1)
            {
                left = new MaxPathSum.BinaryTree(2),
                right = new MaxPathSum.BinaryTree(-1)
            };
            var expected = 3;
            var actual = MaxPathSum.Solution(tree);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            var tree = new MaxPathSum.BinaryTree(-2)
            {
                left = new MaxPathSum.BinaryTree(-1)
                {
                    left = new MaxPathSum.BinaryTree(2),
                    right = new MaxPathSum.BinaryTree(3)
                }
            };
            var expected = 4;
            var actual = MaxPathSum.Solution(tree);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase4()
        {
            var tree = new MaxPathSum.BinaryTree(1)
            {
                left = new MaxPathSum.BinaryTree(-5)
                {
                    left = new MaxPathSum.BinaryTree(0)
                    {
                        left = new MaxPathSum.BinaryTree(-3)
                        {
                            left = new MaxPathSum.BinaryTree(0)
                            {
                                left = new MaxPathSum.BinaryTree(3),
                                right = new MaxPathSum.BinaryTree(1)
                            },
                            right = new MaxPathSum.BinaryTree(1)
                            {
                                left = new MaxPathSum.BinaryTree(2),
                                right = new MaxPathSum.BinaryTree(2)
                            }
                        },
                        right = new MaxPathSum.BinaryTree(-4)
                        {
                            left = new MaxPathSum.BinaryTree(3)
                            {
                                left = new MaxPathSum.BinaryTree(7),
                                right = new MaxPathSum.BinaryTree(-5)
                            },
                            right = new MaxPathSum.BinaryTree(-1)
                        }
                    },
                    right = new MaxPathSum.BinaryTree(2)
                    {
                        left = new MaxPathSum.BinaryTree(1)
                        {
                            left = new MaxPathSum.BinaryTree(-1),
                            right = new MaxPathSum.BinaryTree(-6)
                        },
                        right = new MaxPathSum.BinaryTree(1)
                        {
                            left = new MaxPathSum.BinaryTree(-1),
                            right = new MaxPathSum.BinaryTree(-100)
                        }
                    }
                },
                right = new MaxPathSum.BinaryTree(3)
                {
                    left = new MaxPathSum.BinaryTree(2)
                    {
                        left = new MaxPathSum.BinaryTree(0)
                        {
                            left = new MaxPathSum.BinaryTree(-9),
                            right = new MaxPathSum.BinaryTree(-91)
                        },
                        right = new MaxPathSum.BinaryTree(5)
                        {
                            left = new MaxPathSum.BinaryTree(2),
                            right = new MaxPathSum.BinaryTree(1)
                        }
                    },
                    right = new MaxPathSum.BinaryTree(1)
                    {
                        left = new MaxPathSum.BinaryTree(1)
                        {
                            left = new MaxPathSum.BinaryTree(0),
                            right = new MaxPathSum.BinaryTree(1)
                        },
                        right = new MaxPathSum.BinaryTree(1)
                        {
                            left = new MaxPathSum.BinaryTree(-5),
                            right = new MaxPathSum.BinaryTree(0)
                        }
                    }
                }
            };
            var expected = 15;
            var actual = MaxPathSum.Solution(tree);
            Assert.AreEqual(expected, actual);
        }
    }
}
