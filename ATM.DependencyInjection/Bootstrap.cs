using ATM.Interfaces;
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