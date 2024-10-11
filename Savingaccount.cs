namespace Bankapplikation.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, string accountName, double initialBalance)
            : base(accountNumber, accountName, initialBalance) { }
    }
}