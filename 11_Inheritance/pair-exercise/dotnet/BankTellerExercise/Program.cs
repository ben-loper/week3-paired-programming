using System;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checkingAccount = new CheckingAccount();
            BankAccount savingsAccount = new SavingsAccount();
            BankAccount secondSavingsAcct = new SavingsAccount();

            BankCustomer jayGatsby = new BankCustomer();
            jayGatsby.AddAccount(checkingAccount);
            jayGatsby.AddAccount(savingsAccount);
            jayGatsby.AddAccount(secondSavingsAcct);

            Console.WriteLine($"Jay Gatsby has {jayGatsby.Accounts.Length} accounts.");
            
            checkingAccount.AccountNumber = "Checking";
            savingsAccount.AccountNumber = "Savings";
            secondSavingsAcct.AccountNumber = "Second Savings";

            foreach (var item in jayGatsby.Accounts)
            {
                Console.WriteLine($"Account Number: {item.AccountNumber}");
            }

            checkingAccount.Deposit(2000M);
            savingsAccount.Deposit(2000M);
            secondSavingsAcct.Deposit(1500M);
            
            foreach (var item in jayGatsby.Accounts)
            {
                Console.WriteLine($"Account Name: {item.AccountNumber} - Account Balance: {item.Balance.ToString("C")}");
            }

            checkingAccount.Withdraw(500.00M);
            savingsAccount.Withdraw(1000M);

            foreach (var item in jayGatsby.Accounts)
            {
                Console.WriteLine($"Account Name: {item.AccountNumber} - Account Balance: {item.Balance.ToString("C")}");
            }
            Console.WriteLine("IsVIP: " + jayGatsby.IsVIP);


            savingsAccount.Transfer(checkingAccount, 40.00M);
            Console.WriteLine($"Checking: {checkingAccount.Balance}, Savings: {savingsAccount.Balance}");
            Console.ReadKey();



        }
    }
}
