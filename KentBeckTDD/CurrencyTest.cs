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
            five.times(2);
            Assert.Equals(10, five.amount);
        }

        public class Dollar { 
            public Dollar(int amount) { }
            public void times(int multiplier)
            {

            }
            public int amount;
        }

    }
}
