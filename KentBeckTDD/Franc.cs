using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDD
{
    public class Franc
    {
        private int amount;
        public Franc(int amount)
        {
            this.amount = amount;
        }
        public Franc times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Franc dollar = (Franc)obj;
            return amount == dollar.amount;
        }

    }
}
