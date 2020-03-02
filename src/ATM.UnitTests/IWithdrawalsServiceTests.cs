using ATM.Commom.Exceptions;
using ATM.Common.Exceptions;
using ATM.DependencyInjection;
using ATM.Interfaces.Services;
using ATM.Models;
using Xunit;

namespace ATM.UnitTests
{
    public class IWithdrawalsServiceTests : BaseTest
    {
        [Fact]
        public void ShouldFailOnTryToDoAWithdrawalWithNegativeAmount()
        {
            var expectedMessage = Messages.negative_value_is_invalid;
            
            var service = Modules.Resolve<IWithdrawals>();

            var exception = Assert.Throws<BaseException>(() => service.DoWithdrawal(-10));
            
            Assert.Equal(expectedMessage, exception.Message);   
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(15)]
        public void ShouldFailOnTryToDoAWithdrawalWithAnInvalidAmount(int invalidAmount)
        {
            var expectedMessage = Messages.invalid_amount;
            
            var service = Modules.Resolve<IWithdrawals>();

            var exception = Assert.Throws<BaseException>(() => service.DoWithdrawal(invalidAmount));
            
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Theory]
        [InlineData(10, 1, 0, 0, 0)]
        [InlineData(20, 0, 1, 0, 0)]
        [InlineData(50, 0, 0, 1, 0)]
        [InlineData(100, 0, 0, 0, 1)]
        [InlineData(30, 1, 1, 0, 0)]
        public void ShouldMakeAWithdrawalSuccessfully(int amount, int expectedTenNotes, int expectedTwentyNotes, int expectedFiftyNotes, int expectedHundredNotes)
        {
            var service = Modules.Resolve<IWithdrawals>();

            var withdraw = service.DoWithdrawal(amount);

            Assert.IsType<Withdraw>(withdraw);
            
            Assert.Equal(expectedTenNotes, withdraw.TenNotes);
            Assert.Equal(expectedTwentyNotes, withdraw.TwentyNotes);
            Assert.Equal(expectedFiftyNotes, withdraw.FiftyNotes);
            Assert.Equal(expectedHundredNotes, withdraw.HundredNotes);
        }
    }
}