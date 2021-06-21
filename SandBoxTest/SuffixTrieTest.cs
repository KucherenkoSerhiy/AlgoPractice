namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SuffixTrieTest
    {
        [Test]
        public void TestCase1()
        {
            var str = "babc";
            var sut = new SuffixTrie(str);
            Assert.IsTrue(sut.Contains(str));
        }

        [Test]
        public void TestCase2()
        {
            var str = "1234556789";
            var sut = new SuffixTrie(str);
            Assert.IsTrue(sut.Contains("9"));
            Assert.IsTrue(sut.Contains("89"));
            Assert.IsTrue(sut.Contains("789"));
            Assert.IsTrue(sut.Contains("6789"));
            Assert.IsTrue(sut.Contains("56789"));
            Assert.IsFalse(sut.Contains("456789"));
            Assert.IsFalse(sut.Contains("3456789"));
            Assert.IsFalse(sut.Contains("23456789"));
            Assert.IsFalse(sut.Contains("123456789"));
            Assert.IsFalse(sut.Contains("45567"));
        }

        [Test]
        public void TestCase3()
        {
            var str = "testtest";
            var sut = new SuffixTrie(str);
            Assert.IsTrue(sut.Contains("t"));
            Assert.IsTrue(sut.Contains("st"));
            Assert.IsTrue(sut.Contains("est"));
            Assert.IsTrue(sut.Contains("test"));
            Assert.IsTrue(sut.Contains("ttest"));
            Assert.IsTrue(sut.Contains("sttest"));
            Assert.IsTrue(sut.Contains("esttest"));
            Assert.IsTrue(sut.Contains("testtest"));
            Assert.IsFalse(sut.Contains("tt"));
        }
    }
}
