using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace KentBeckTDD
{
    [TestFixture]
    public class CurrencyTest
    {
        [Test]
        public void testMultiplicstion()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(10, product.amount);
            product = five.times(3);
            Assert.AreEqual(15, product.amount);
        }
       
    }
    public class Dollar
    {
        public int amount;
        public Dollar(int amount) {
            this.amount = amount;
        }
        public Dollar times(int multiplier)
        {
            return new Dollar (amount * multiplier);
        }
        
    }
}
