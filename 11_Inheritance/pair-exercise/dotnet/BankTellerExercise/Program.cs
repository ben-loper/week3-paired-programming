using System;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checkingAccount = new CheckingAccount();
            BankAccount savingsAccount = new SavingsAccount();

            BankCustomer jayGatsby = new BankCustomer();
            jayGatsby.AddAccount(checkingAccount);
            jayGatsby.AddAccount(savingsAccount);

            Console.WriteLine($"Jay Gatsby has {jayGatsby.Accounts.Length} accounts.");
            
            checkingAccount.AccountNumber = "Checking";
            savingsAccount.AccountNumber = "Savings";

            foreach (var item in jayGatsby.Accounts)
            {
                Console.WriteLine($"Account Number: {item.AccountNumber}");
            }

            checkingAccount.Deposit(300.00M);
            savingsAccount.Deposit(140);
            
            foreach (var item in jayGatsby.Accounts)
            {
                Console.WriteLine($"Account Name: {item.AccountNumber} - Account Balance: {item.Balance.ToString("C")}");
            }

            checkingAccount.Withdraw(0.00M);
            savingsAccount.Withdraw(0);

            foreach (var item in jayGatsby.Accounts)
            {
                Console.WriteLine($"Account Name: {item.AccountNumber} - Account Balance: {item.Balance.ToString("C")}");
            }

            savingsAccount.Transer(checkingAccount, 40.00M);
            Console.WriteLine($"Checking: {checkingAccount.Balance}, Savings: {savingsAccount.Balance}");
            Console.ReadKey();

            

        }
    }
}
