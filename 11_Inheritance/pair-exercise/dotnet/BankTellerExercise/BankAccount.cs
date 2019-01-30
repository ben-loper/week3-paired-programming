using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount ()
        {
            Balance = 0.0M;
        }

        public decimal Deposit(decimal amountToDeposit)
        {
             return Balance += amountToDeposit;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return Balance -= amountToWithdraw;
        }

        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {

            decimal transfer = Withdraw(transferAmount);

            if(this is SavingsAccount && Balance < 150)
            {
                if (transfer != 0)
                {
                    transfer = Balance - Withdraw(transferAmount) - 2;
                }
            }
            else if(this is CheckingAccount && Balance < 0)
            {
                transfer = Balance - Withdraw(transferAmount) - 10;
            }

            destinationAccount.Deposit(transfer);
        }
               
    }
}
