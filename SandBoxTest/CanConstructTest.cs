namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class CanConstructTest
    {
        [Test]
        public void BruteForce_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd" };
            var sut = new CanConstruct();
            bool response = sut.BruteForce(target, wordBank);
            Assert.IsTrue(response);
        }

        [Test]
        public void BruteForce_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new CanConstruct();
            bool response = sut.BruteForce(target, wordBank);
            Assert.IsFalse(response);
        }

        [Test]
        public void BruteForce_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new CanConstruct();
            bool response = sut.BruteForce(target, wordBank);
            Assert.IsTrue(response);
        }

        // will never end
        //[Test]
        //public void BruteForce_Case4()
        //{
        //    string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
        //    string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
        //    var sut = new CanConstruct();
        //    bool response = sut.BruteForce(target, wordBank);
        //    Assert.IsFalse(response);
        //}

        [Test]
        public void Memoized_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd" };
            var sut = new CanConstruct();
            bool response = sut.Memoized(target, wordBank);
            Assert.IsTrue(response);
        }

        [Test]
        public void Memoized_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new CanConstruct();
            bool response = sut.Memoized(target, wordBank);
            Assert.IsFalse(response);
        }

        [Test]
        public void Memoized_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new CanConstruct();
            bool response = sut.Memoized(target, wordBank);
            Assert.IsTrue(response);
        }

        // will never end
        [Test]
        public void Memoized_Case4()
        {
            string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
            string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
            var sut = new CanConstruct();
            bool response = sut.Memoized(target, wordBank);
            Assert.IsFalse(response);
        }

        [Test]
        public void Tabulated_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd" };
            var sut = new CanConstruct();
            bool response = sut.Tabulated(target, wordBank);
            Assert.IsTrue(response);
        }

        [Test]
        public void Tabulated_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new CanConstruct();
            bool response = sut.Tabulated(target, wordBank);
            Assert.IsFalse(response);
        }

        [Test]
        public void Tabulated_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new CanConstruct();
            bool response = sut.Tabulated(target, wordBank);
            Assert.IsTrue(response);
        }

        // will never end
        [Test]
        public void Tabulated_Case4()
        {
            string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
            string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
            var sut = new CanConstruct();
            bool response = sut.Tabulated(target, wordBank);
            Assert.IsFalse(response);
        }
    }
}
