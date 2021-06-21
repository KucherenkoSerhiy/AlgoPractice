namespace AlgoExpertTest
{
    using AlgoExpert;
    using NUnit.Framework;

    [TestFixture]
    public class AllConstructTest
    {
        [Test]
        public void BruteForce_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd", "ef" };
            var sut = new AllConstruct();
            var response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(3, response.Count);
        }

        [Test]
        public void BruteForce_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new AllConstruct();
            var response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(0, response.Count);
        }

        [Test]
        public void BruteForce_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new AllConstruct();
            var response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(1, response.Count);
        }

        [Test]
        public void BruteForce_Case4()
        {
            string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            var sut = new AllConstruct();
            var response = sut.BruteForce(target, wordBank);
            Assert.AreEqual(2, response.Count);
        }

        // will never end
        //[Test]
        //public void BruteForce_Case5()
        //{
        //    string target = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza";
        //    string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz" };
        //    var sut = new AllConstruct();
        //    var response = sut.BruteForce(target, wordBank);
        //    Assert.AreEqual(0, response.Count);
        //}

        [Test]
        public void Memoized_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd", "ef" };
            var sut = new AllConstruct();
            var response = sut.Memoized(target, wordBank);
            Assert.AreEqual(3, response.Count);
        }

        [Test]
        public void Memoized_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new AllConstruct();
            var response = sut.Memoized(target, wordBank);
            Assert.AreEqual(0, response.Count);
        }

        [Test]
        public void Memoized_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new AllConstruct();
            var response = sut.Memoized(target, wordBank);
            Assert.AreEqual(1, response.Count);
        }

        [Test]
        public void Memoized_Case4()
        {
            string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            var sut = new AllConstruct();
            var response = sut.Memoized(target, wordBank);
            Assert.AreEqual(2, response.Count);
        }

        //// still takes long as we return a ton of responses
        //[Test]
        //public void Memoized_Case5()
        //{
        //    string target = "zzzzzzzzzzzzzzzzzzzzzza";
        //    string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz", "a" };
        //    var sut = new AllConstruct();
        //    var response = sut.Memoized(target, wordBank);
        //    Assert.AreEqual(1825529, response.Count);
        //}

        [Test]
        public void Tabulated_Case1()
        {
            string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd", "ef" };
            var sut = new AllConstruct();
            var response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(3, response.Count);
        }

        [Test]
        public void Tabulated_Case2()
        {
            string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            var sut = new AllConstruct();
            var response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(0, response.Count);
        }

        [Test]
        public void Tabulated_Case3()
        {
            string target = "";
            string[] wordBank = { "a" };
            var sut = new AllConstruct();
            var response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(1, response.Count);
        }

        [Test]
        public void Tabulated_Case4()
        {
            string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            var sut = new AllConstruct();
            var response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(2, response.Count);
        }

        //// still takes long as we return a ton of responses
        [Test]
        public void Tabulated_Case5()
        {
            string target = "zzzzzzzzzzzzzzzzza";
            string[] wordBank = { "z", "zz", "zzz", "zzzz", "zzzzz", "zzzzzz", "a" };
            var sut = new AllConstruct();
            var response = sut.Tabulated(target, wordBank);
            Assert.AreEqual(59448, response.Count);
        }
    }
}
