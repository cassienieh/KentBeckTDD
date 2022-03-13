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

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).equals(new Dollar(5)));
            Assert.IsTrue(new Dollar(5).equals(new Dollar(6)));
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

        public bool equals(Object obj)
        {
            return true;
        }
        
    }
}
