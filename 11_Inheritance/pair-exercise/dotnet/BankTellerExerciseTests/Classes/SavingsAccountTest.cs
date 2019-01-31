using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BankTellerExerciseTests
{
    [TestClass]
    public class SavingsAccountTest
    {
        private SavingsAccount _accountDeposit = new SavingsAccount();
        private SavingsAccount _accountWithdraw = new SavingsAccount();

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
            decimal expected = 700m;
            _accountWithdraw.Withdraw(701m);
            decimal actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 701");

            expected = 150M;
            _accountWithdraw.Withdraw(550M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 550");

            expected = 148M;
            _accountWithdraw.Withdraw(2M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 2");

            expected = 144M;
            _accountWithdraw.Withdraw(2M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 2");

            expected = 144M;
            _accountWithdraw.Withdraw(143M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 143");

            expected = 0M;
            _accountWithdraw.Withdraw(142M);
            actual = _accountWithdraw.Balance;

            Assert.AreEqual(expected, actual, "Input was: 142");

        }
    }
}
