namespace BE_Day_3_esercizio
{
    internal class BankAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsBankAccountOpen { get; set; }
        public decimal AccountBalance { get; set; }

        public BankAccount()
        {
            IsBankAccountOpen = CloseAccount();
            AccountBalance = 0;
        }

        public bool OpenAccount()
        {
            return IsBankAccountOpen = true;
        }
        public bool CloseAccount()
        {
            return IsBankAccountOpen = false;
        }
        public decimal Deposit(decimal value)
        {
            return AccountBalance += value;
        }
        public decimal Withdrawal(decimal value)
        {
            return AccountBalance -= value;
        }
    }
}
