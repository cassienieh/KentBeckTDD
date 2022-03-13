using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDD
{
    class CurrencyTest
    {
        public void testMultiplicstion()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            assertEquals(10, five.amount);
        }

        public class Dollar { 
            public Dollar(int amount) { }
        }

    }
}
