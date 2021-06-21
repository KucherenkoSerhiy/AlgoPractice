namespace AlgoExpertTest
{
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ValidIPAddressesTest
    {
        [Test]
        public void TestCase1()
        {
            var str = "1921680";
            var expected = new[]
            {
                "1.9.216.80", 
                "1.92.16.80", 
                "1.92.168.0", 
                "19.2.16.80", 
                "19.2.168.0", 
                "19.21.6.80", 
                "19.21.68.0", 
                "19.216.8.0", 
                "192.1.6.80", 
                "192.1.68.0", 
                "192.16.8.0"
            };
            var sut = new ValidIPAddresses();
            var actual = sut.Solve(str);
            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase2()
        {
            var str = "3700100";
            var expected = new[]
            {
                "3.70.0.100", 
                "37.0.0.100"
            };
            var sut = new ValidIPAddresses();
            var actual = sut.Solve(str);
            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase3()
        {
            var str = "255255255255";
            var expected = new[]
            {
                "255.255.255.255"
            };
            var sut = new ValidIPAddresses();
            var actual = sut.Solve(str);
            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TestCase4()
        {
            var str = "255255255256";
            var expected = new string[] { };
            var sut = new ValidIPAddresses();
            var actual = sut.Solve(str);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
