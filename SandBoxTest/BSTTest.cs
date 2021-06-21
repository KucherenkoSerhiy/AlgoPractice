namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    public class BSTTest
    {
        [Test]
        public void TestCase1()
        {
            BST bst = new BST(10)
            {
                left = new BST(5)
                {
                    left = new BST(2)
                    {
                        left = new BST(1)
                    },
                    right = new BST(5)
                },
                right = new BST(15)
                {
                    left = new BST(13)
                    {
                        right = new BST(14)
                    },
                    right = new BST(22)
                }
            };
            BST expectedAfterInsert12 = new BST(10)
            {
                left = new BST(5)
                {
                    left = new BST(2)
                    {
                        left = new BST(1)
                    },
                    right = new BST(5)
                },
                right = new BST(15)
                {
                    left = new BST(13)
                    {
                        left = new BST(12),
                        right = new BST(14)
                    },
                    right = new BST(22)
                }
            };
            BST expectedAfterRemove10 = new BST(12)
            {
                left = new BST(5)
                {
                    left = new BST(2)
                    {
                        left = new BST(1)
                    },
                    right = new BST(5)
                },
                right = new BST(15)
                {
                    left = new BST(13)
                    {
                        right = new BST(14)
                    },
                    right = new BST(22)
                }
            };

            bst.Insert(12);
            bst.Should().BeEquivalentTo(expectedAfterInsert12);
            bst.Remove(10);
            bst.Should().BeEquivalentTo(expectedAfterRemove10);
            Assert.IsTrue(bst.Contains(15));
        }

        [Test]
        public void TestCase2()
        {
            BST bst = new BST(10);
            bst.Insert(5);
            bst.Insert(15);
            bst.Remove(5);
            bst.Remove(15);
            bst.Remove(10);

            BST expected = new BST(10);
            bst.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase3()
        {
            BST bst = new BST(10);
            bst.Insert(5);
            bst.Insert(15);
            Assert.IsTrue(bst.Contains(10));
            Assert.IsTrue(bst.Contains(5));
            Assert.IsTrue(bst.Contains(15));
            bst.Remove(10);
            bst.Remove(5);
            bst.Remove(15);
            Assert.False(bst.Contains(10));
            Assert.False(bst.Contains(5));
            Assert.IsTrue(bst.Contains(15));

            BST expected = new BST(15);
            bst.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase4()
        {
            BST bst = new BST(10);
            bst.Insert(5);
            bst.Insert(15);
            Assert.IsTrue(bst.Contains(10));
            Assert.IsTrue(bst.Contains(5));
            Assert.IsTrue(bst.Contains(15));
            bst.Remove(10);
            BST expectedAfterRemove10 = new BST(15)
            {
                left = new BST(5)
            };
            bst.Should().BeEquivalentTo(expectedAfterRemove10);
            bst.Remove(5);
            bst.Remove(15);
            Assert.False(bst.Contains(10));
            Assert.False(bst.Contains(5));
            Assert.IsTrue(bst.Contains(15));

            BST expected = new BST(15);
            bst.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase5()
        {
            BST bst = new BST(1);
            bst.Insert(2);
            bst.Insert(3);
            bst.Insert(4);
            bst.Insert(5);
            bst.Insert(6);
            bst.Insert(7);
            bst.Insert(8);
            bst.Insert(9);
            bst.Insert(10);
            bst.Insert(11);
            bst.Insert(12);
            bst.Insert(13);
            bst.Insert(14);
            bst.Insert(15);
            bst.Insert(16);
            bst.Insert(17);
            bst.Insert(18);
            bst.Insert(19);
            bst.Insert(20);
            bst.Remove(2);
            bst.Remove(4);
            bst.Remove(6);
            bst.Remove(8);
            bst.Remove(11);
            bst.Remove(13);
            bst.Remove(15);
            bst.Remove(17);
            bst.Remove(19);
            bst.Insert(1);
            bst.Insert(2);
            bst.Insert(3);
            bst.Insert(4);
            bst.Insert(5);
            bst.Insert(6);
            bst.Insert(7);
            bst.Insert(8);
            bst.Insert(9);
            bst.Insert(10);
            Assert.IsFalse(bst.Contains(9000));
        }

        [Test]
        public void TestCase6()
        {
            BST bst = new BST(1);
            bst.Insert(2);
            bst.Insert(3);
            bst.Insert(4);
            bst.Remove(1);
            BST expected = new BST(2)
            {
                right = new BST(3)
                {
                    right = new BST(4)
                }
            };
            bst.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase10()
        {
            BST bst = new BST(10);
            bst.Insert(5);
            bst.Insert(15);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(13);
            bst.Insert(22);
            bst.Insert(1);
            bst.Insert(14);
            bst.Insert(12);
            bst.Remove(5);
            bst.Remove(5);
            bst.Remove(12);
            bst.Remove(13);
            bst.Remove(14);
            bst.Remove(22);
            bst.Remove(2);
            bst.Remove(1);
            Assert.IsTrue(bst.Contains(15));

            BST expected = new BST(10)
            {
                right = new BST(15)
            };
            bst.Should().BeEquivalentTo(expected);
        }

    }
}
