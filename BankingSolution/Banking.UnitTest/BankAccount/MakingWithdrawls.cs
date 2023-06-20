
namespace Banking.UnitTest.BankAccount
{
    public class MakingWithdrawls
    {
        [Theory]
        [InlineData(100)]
        [InlineData(125.23)]
        [InlineData(80000)]
        public void MakingAWithdrawlDecreasesTheBalance(decimal amountToWithdraw)
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdraw(amountToWithdraw);

            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
        }

        [Fact]
        public void CanTakeFullBalance()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdraw(openingBalance);

            Assert.Equal(0, account.GetBalance());
        }
    }
}
