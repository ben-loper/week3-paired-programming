using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CheckingAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            const decimal minAmount = -100.00M;
            const decimal overdraftFee = 10.00M;
            if (Balance - amountToWithdraw <= minAmount || Balance - amountToWithdraw - overdraftFee < minAmount || amountToWithdraw == 0)
            {
                amountToWithdraw = 0.00M;
            } 
            else if (Balance - amountToWithdraw < 0.00M)
            {
                amountToWithdraw += overdraftFee;
            }
            return base.Withdraw(amountToWithdraw);
        }
    }
}
