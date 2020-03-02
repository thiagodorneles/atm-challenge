using ATM.Interfaces;
using ATM.Interfaces.Services;
using ATM.Services;

namespace ATM.DependencyInjection
{
    public static class Bootstrap
    {
        public static void RegisterModules()
        {
            Modules.Register<IWithdrawals, WithdrawalsService>();
        }
    }
}