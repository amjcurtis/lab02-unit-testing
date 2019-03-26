using lab02_unit_testing;
using Xunit;

namespace XUnitTestProject_UnitTesting
{
    public class UnitTest1
    {

        /// <summary>
        /// Tests whether can return updated balance after withdrawal of funds
        /// </summary>
        [Fact]
        public void CanReturnNewBalanceFromWithdrawFunds()
        {
            // Arrange
            // Set initial account balance that Program.WithdrawFunds below will use
            Program.balance = 1000m;

            // Act
            decimal newBalanceAfterWithdraw = Program.WithdrawFunds(50m);
            
            // Assert
            Assert.Equal(950m, newBalanceAfterWithdraw);
        }

        /// <summary>
        /// Tests whether user can overdraw account
        /// </summary>
        [Fact]
        public void CannotOverdrawAccount()
        {
            // Arrange
            Program.balance = 500m;

            // Act
            decimal balanceAfterOverdraw = Program.WithdrawFunds(600m);

            // Assert
            Assert.NotEqual(-100m, balanceAfterOverdraw);
        }

        /// <summary>
        /// Tests whether can return updated balance after deposit
        /// </summary>
        [Fact]
        public void CanReturnNewBalanceFromDepositFunds()
        {
            // Arrange
            Program.balance = 1000m;

            // Act
            decimal newBalanceAfterDeposit = Program.DepositFunds(200m);

            // Assert
            Assert.Equal(1200m, newBalanceAfterDeposit); 
        }

        /// <summary>
        /// Tests whether user can deposit negative amount
        /// </summary>
        [Fact]
        public void CannotDepositNegativeAmount()
        {
            // Arrange
            Program.balance = 200m;

            // Act
            decimal balanceAfterNegativeDeposit = Program.DepositFunds(-10m);

            // Assert
            Assert.NotEqual(190m, balanceAfterNegativeDeposit);
        }
    }
}
