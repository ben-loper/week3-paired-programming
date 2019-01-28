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
