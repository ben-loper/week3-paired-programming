using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class SavingsAccount : BankAccount
    {
        
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            const decimal minAmount = 150.00M;
            const decimal serviceFee = 2.00M;
            if (amountToWithdraw > Balance || (Balance < 150M && Balance - serviceFee - amountToWithdraw < 0) || amountToWithdraw == 0)
            {
                amountToWithdraw = 0;
            }
            else if (Balance < minAmount)
            {
                amountToWithdraw += serviceFee;
            }
            return amountToWithdraw;
        }
    }
}
