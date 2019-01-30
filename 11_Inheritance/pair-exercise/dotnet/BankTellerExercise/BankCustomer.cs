using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVIP
        { get
            {
                bool isVIP = false;
                decimal balance = 0;
                foreach (BankAccount account in _accounts)
                {
                    balance += account.Balance;
                }
                if (balance >= 25000)
                {
                    isVIP =  true;
                }
                return isVIP;
            }
        }

        public BankAccount[] Accounts
        {
            get
            {
                return _accounts.ToArray();
            }
        }
        private List<BankAccount> _accounts = new List<BankAccount>();

        public void AddAccount(BankAccount newAccount)
        {
            _accounts.Add(newAccount);
        }
        
            



    }
}
