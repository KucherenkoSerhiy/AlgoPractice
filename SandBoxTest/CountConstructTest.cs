namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class CountConstructTest
    {
        [Test]
        public void BruteForce_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd" };
            var sut = new CountConstruct();
            int response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(1, response);
        }

        [Test]
        public void BruteForce_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new CountConstruct();
            int response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(0, response);
        }

        [Test]
        public void BruteForce_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new CountConstruct();
            int response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(1, response);
        }

        [Test]
        public void BruteForce_Case4()
        {
            string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            var sut = new CountConstruct();
            int response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(2, response);
        }

        // will never end
        //[Test]
        //public void BruteForce_Case5()
        //{
        //    string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
        //    string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
        //    var sut = new CountConstruct();
        //    int response = sut.BruteForce(target, wordBank);
        //    Assert.AreEqual(0, response);
        //}

        [Test]
        public void Memoized_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd" };
            var sut = new CountConstruct();
            int response = sut.Memoized(target, wordBank);
            Assert.AreEqual(1, response);
        }

        [Test]
        public void Memoized_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new CountConstruct();
            int response = sut.Memoized(target, wordBank);
            Assert.AreEqual(0, response);
        }

        [Test]
        public void Memoized_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new CountConstruct();
            int response = sut.Memoized(target, wordBank);
            Assert.AreEqual(1, response);
        }

        [Test]
        public void Memoized_Case4()
        {
            string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            var sut = new CountConstruct();
            int response = sut.Memoized(target, wordBank);
            Assert.AreEqual(2, response);
        }

        [Test]
        public void Memoized_Case5()
        {
            string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
            string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
            var sut = new CountConstruct();
            int response = sut.Memoized(target, wordBank);
            Assert.AreEqual(0, response);
        }

        [Test]
        public void Tabulated_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd", "ef" };
            var sut = new CountConstruct();
            int response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(3, response);
        }

        [Test]
        public void Tabulated_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new CountConstruct();
            int response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(0, response);
        }

        [Test]
        public void Tabulated_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new CountConstruct();
            int response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(1, response);
        }

        [Test]
        public void Tabulated_Case4()
        {
            string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            var sut = new CountConstruct();
            int response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(2, response);
        }

        [Test]
        public void Tabulated_Case5()
        {
            string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
            string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
            var sut = new CountConstruct();
            int response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(0, response);
        }
    }
}
