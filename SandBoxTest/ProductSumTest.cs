namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using NUnit.Framework;

    public class ProductSumTest
    {
        [Test]
        public void TestCase1()
        {
            List<object> array = new List<object>
            {
                5, 2, new List<object>{7, -1}, 3, new List<object>{6, new List<object>{-13, 8}, 4}
            };
            Assert.AreEqual(12, ProductSum.Solution1(array));
        }
    }
}
