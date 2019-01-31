using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankCustomerTests
    {
        BankCustomer customer = new BankCustomer();
        CheckingAccount checkingAccount = new CheckingAccount();
        SavingsAccount savingsAccount = new SavingsAccount();

        //public void AddAccount(BankAccount newAccount)
        [TestMethod]
        public void AddAcountTest()
        {
            customer.AddAccount(checkingAccount);

            int expected = 1;
            int actual = customer.Accounts.Length;
            Assert.AreEqual(expected, actual, "Input was: added checking account to customer object");

            customer.AddAccount(savingsAccount);
            expected = 2;
            actual = customer.Accounts.Length;
            Assert.AreEqual(expected, actual, "Input was: added saving account to customer object");
        }

        [TestMethod]
        public void IsVIPTest()
        {
            customer.AddAccount(checkingAccount);
            customer.AddAccount(savingsAccount);

            checkingAccount.Deposit(24999);

            bool expected = false;
            bool actual = customer.IsVIP;

            Assert.AreEqual(expected, actual, "Accounts total was 24,999");


            savingsAccount.Deposit(1);
            expected = true;
            actual = customer.IsVIP;

            Assert.AreEqual(expected, actual, "Accounts total was 25,000");

            checkingAccount.Withdraw(1);
            expected = false;
            actual = customer.IsVIP;

            Assert.AreEqual(expected, actual, "Accounts total was 24,999");
        }
    }
}
