using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class CheckingAccountTest
    {
        private CheckingAccount _accountDeposit = new CheckingAccount();
        private CheckingAccount _accountWithdraw = new CheckingAccount();

        [TestMethod]
        public void DepositTest()
        {
            decimal expected = 300.00M;
            decimal actual = _accountDeposit.Deposit(300);

            Assert.AreEqual(expected, actual, "Input was: 300");

            expected = 500;
            actual = _accountDeposit.Deposit(200);

            Assert.AreEqual(expected, actual, "Input was: 200");

        }

        [TestMethod]
        public void WithdrawTest()
        {
            _accountWithdraw.Deposit(700M);
            decimal expected = 400M;
            _accountWithdraw.Withdraw(300M);
            decimal actual = _accountWithdraw.Balance;

           Assert.AreEqual(expected, actual, "Input was: 300");

            expected = 0M;
            _accountWithdraw.Withdraw(400M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 400");

            expected = 0M;
            _accountWithdraw.Withdraw(91M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 91");

            expected = -100M;
            _accountWithdraw.Withdraw(90M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 90");
        }
    }
}
