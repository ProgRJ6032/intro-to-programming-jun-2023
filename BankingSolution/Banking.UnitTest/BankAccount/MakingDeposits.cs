
namespace Banking.UnitTest.BankAccount;

public class MakingDeposits
{
    [Fact]
    public void DepositIncreasesBalance()
    {
        // Given
        // If I have an account and I want to deposit 100
        Account account = new Account();
        decimal openingBalance = account.GetBalance();
        decimal ammountToDeposit = 100M;

        // When
        // I do the deposit
        account.Deposit(ammountToDeposit);

        // Then
        // I can verify if the new balance is 100 more than the balance was before
        Assert.Equal(openingBalance + ammountToDeposit, account.GetBalance());
    }
}
