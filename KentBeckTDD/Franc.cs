using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDD
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.Amount = amount;
        }
        public Franc times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return Amount == money.GetAmount();
        }

    }
}
