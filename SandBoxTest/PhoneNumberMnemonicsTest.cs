namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class PhoneNumberMnemonicsTest
    {
        [Test]
        public void TestCase1()
        {
            var phoneNumber = "1905";
            var expected = new List<string>
            {
                "1w0j",
                "1w0k",
                "1w0l",
                "1x0j",
                "1x0k",
                "1x0l",
                "1y0j",
                "1y0k",
                "1y0l",
                "1z0j",
                "1z0k",
                "1z0l"
            };
            var sut = new PhoneNumberMnemonics();
            var actual = sut.Solve(phoneNumber);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
