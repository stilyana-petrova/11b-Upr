using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountTest
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return  balance; }
            set {  balance = value; }
        }
        public BankAccount(decimal amount=0)
        {
            this.balance = amount;
        }
        public void Deposit(decimal cash)
        {
            this.balance += cash;
        }
        public void Increase(decimal percent)
        {
            this.balance = this.balance +this.balance*percent/100;
        }
        public void Bonus()
        {
            if (this.balance>1000 && this.balance<2000)
            {
                this.balance += 100;
            }
            if (this.balance>2000 && this.balance<=3000)
            {
                this.balance += 200;
            }
            if (this.balance>3000)
            {
                this.balance += 300;
            }
        }

    }
}
