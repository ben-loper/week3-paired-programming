using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public abstract class BankAccount
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
            
            decimal beforeBalance = Balance;

            Withdraw(transferAmount);

            if (Balance != beforeBalance)
            {
                destinationAccount.Deposit(transferAmount);
            }
        }
               
    }
}
