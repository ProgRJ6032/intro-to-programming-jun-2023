
namespace Banking.UnitTest.BankAccount
{
    public class WithdrawlGuards
    {
        [Fact]
        public void OverdraftNotAllowed()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdraw(openingBalance + 0.01M);

            Assert.Equal(openingBalance, account.GetBalance());
        }

    }
}
