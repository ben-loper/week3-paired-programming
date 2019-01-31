using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void TransferTest()
        {
            CheckingAccount checkingAccount = new CheckingAccount();
            SavingsAccount savingsAccount = new SavingsAccount();

            checkingAccount.Deposit(1000M);
            savingsAccount.Deposit(700M);

            decimal expected = 800M;
            checkingAccount.Transfer(savingsAccount, 100M);
            decimal actual = savingsAccount.Balance;

            Assert.AreEqual(expected, actual, "Transfered 100 from checking to savings");

            expected = 900m;
            actual = checkingAccount.Balance;

            Assert.AreEqual(expected, actual, "Transfered 100 from checking to savings");

            expected = 900M;
            checkingAccount.Transfer(savingsAccount, 1001M);
            actual = checkingAccount.Balance;

            Assert.AreEqual(expected, actual, "Transfered 1001 from checking to savings");

            expected = 800M;
            actual = savingsAccount.Balance;

            Assert.AreEqual(expected, actual, "Transfered 1001 from checking to savings");

          
        }
    }
}

