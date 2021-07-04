namespace InterviewTest
{
    using Interview;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ValidParentesisTest
    {
        [Test]
        public void T2_Case1()
        {
            var sut = new ValidParentesis();
            var input = "()[]{}";

            Assert.IsTrue(sut.Solution(input));
        }

        [Test]
        public void T2_Case2()
        {
            var sut = new ValidParentesis();
            var input = ")(";

            Assert.IsFalse(sut.Solution(input));
        }

        [Test]
        public void T2_Case3()
        {
            var sut = new ValidParentesis();
            var input = "(((((((((())))))))))";

            Assert.IsTrue(sut.Solution(input));
        }

        [Test]
        public void T2_Case4()
        {
            var sut = new ValidParentesis();
            var input = "{";

            Assert.IsFalse(sut.Solution(input));
        }

        [Test]
        public void T2_Case5()
        {
            var sut = new ValidParentesis();
            var input = "";

            Assert.IsTrue(sut.Solution(input));
        }
    }
}
