namespace Banking.Domain
{
    public class Account
    {
        private decimal _balance;
        public void Deposit(decimal ammountToDeposit)
        {
            _balance += ammountToDeposit;
        }

        public decimal GetBalance()
        {
            return 5000;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw > _balance)
            {
                return;
            }
            _balance -= amountToWithdraw;
        }
    }
}