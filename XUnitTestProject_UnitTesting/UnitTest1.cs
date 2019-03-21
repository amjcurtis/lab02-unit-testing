using lab02_unit_testing;
using Xunit;

namespace XUnitTestProject_UnitTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100)]
        // [InlineData(500)]
        // [InlineData(600)]

        public void CanReturnNewBalance(decimal amtToWithdraw)
        {
            decimal returnedNewBalance = Program.WithdrawFunds(amtToWithdraw);
            decimal comparisonNumber = 400m;

            Assert.Equal(comparisonNumber, returnedNewBalance);
        }

    }
}
