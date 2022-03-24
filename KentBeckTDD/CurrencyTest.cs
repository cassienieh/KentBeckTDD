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
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [Test]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.times(2));
            Assert.AreEqual(new Franc(15), five.times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
       
    } 
}
