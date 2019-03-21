using lab02_unit_testing;
using Xunit;

namespace XUnitTestProject_UnitTesting
{
    public class UnitTest1
    {

        //[Theory]
        //[InlineData(100)]
        //// [InlineData(500)]
        //// [InlineData(600)]

        //public void CanReturnNewBalance(decimal amtToWithdraw)
        //{

        //    // Assert
        //    Program.balance = 500m;


        //    decimal newBalance = Program.WithdrawFunds(amtToWithdraw);
        //    decimal comparisonNumber = 400m;

        //    Assert.Equal(Program.balance, comparisonNumber);
        //}

        [Fact]
        public void CanReturnNewBalance()
        {
            // Arrange
            Program.balance = 1000m;

            // Act
            decimal newBalance = Program.WithdrawFunds(50);
            //decimal comparisonNumber = 400m;

            // Assert
            //Assert.Equal(comparisonNumber, newBalance);
            Assert.Equal(950m, newBalance);
        }
    }
}
