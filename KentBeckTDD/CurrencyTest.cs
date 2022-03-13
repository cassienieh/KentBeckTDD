﻿using System;
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
            Assert.AreEqual(10, five.amount);
            five.times(3);
            Assert.AreEqual(15, five.amount);
        }
       
    }
    public class Dollar
    {
        public int amount;
        public Dollar(int amount) {
            this.amount = amount;
        }
        public void times(int multiplier)
        {
            amount *= multiplier;
        }
        
    }
}
