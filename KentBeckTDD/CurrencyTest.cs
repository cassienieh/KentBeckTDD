using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
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
            new Dollar(10).Should().BeEquivalentTo(five.times(2));
            new Dollar(15).Should().BeEquivalentTo(five.times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).equals(new Dollar(6)));
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
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }
        
    }
}
