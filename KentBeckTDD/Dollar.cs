using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDD
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }
        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }

    }

    public class Money
    {
        protected int amount;
    }
}
