using NUnit.Framework;
using BankAccountTest;
using System;

namespace BankingSystem.Test
{
    [TestFixture]
    public class Tests
    {
       [Test]
       public void AccountInitializeWithPositiveValue()
        {
            BankAccount account = new BankAccount(1000m);
            Assert.AreEqual(1000m, account.Balance);
        }
        [Test]
        public void DepositShouldAddMoney()
        {
            BankAccount account = new BankAccount();
            account.Deposit(50);
            Assert.IsTrue(account.Balance == 50);
        }
        [Test]
        public void IncreaseMethodShouldAddPercentToBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(100);
            account.Increase(10);
            Assert.AreEqual(110m, account.Balance);
        }
        [Test]
        public void IsBonusMethodWorkCorrectly()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1100);
            account.Bonus();
            Assert.AreEqual(1200, account.Balance);
        }
        [Test]
        public void PaymentForCreditShouldThrowrAgumentExceptionWhenNotEnoughMoney()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(200));
        }
        [Test]
        public void PaymentForCreditShouldThrowArgumentExceptionWhenPaymentIsNegative()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(-10));
        }
        [Test]
        public void PaymentForCreditShouldThrowrgumentExceptionWhenPaymentIsZero()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(0));
        }
    }
}