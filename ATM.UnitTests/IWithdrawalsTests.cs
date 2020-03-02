using ATM.DependencyInjection;
using ATM.Interfaces.Services;
using Xunit;

namespace ATM.UnitTests
{
    public class IWithdrawalsTests : BaseTest
    {
        [Fact]
        public void ShouldReturnOne()
        {
                var service = Modules.Resolve<IWithdrawals>();
                
                Assert.Equal(1, service.DoWithdrawal());
        }
    }
}