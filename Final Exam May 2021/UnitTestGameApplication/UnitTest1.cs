using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameApplication;

namespace UnitTestGameApplication
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceDecrease()
        {
            Game g1 = new Game("Minecraft", 88, "Test Description", "PC", 20, "");
            decimal finalPrice = 10;

            g1.DecreasePrice(2);

            Assert.AreEqual(finalPrice, g1.Price);
        }
    }
}
