using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDD
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }
        public Dollar times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }    
    }

    public class Money
    {
        protected int Amount;
        public int GetAmount()
        {
            return Amount;
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return Amount == money.GetAmount();
        }
    }
}
