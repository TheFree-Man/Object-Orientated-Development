using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Q1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceIncrease()
        {
            Phone p1 = new Phone("Galaxy s20", 500000000, "Android");
            decimal finalPrice = 550m;

            //ACT
            p1.IncreasePrice(0.1);

            //ASSERT
            Assert.AreEqual(finalPrice, p1.Price);
        }
    }
}
