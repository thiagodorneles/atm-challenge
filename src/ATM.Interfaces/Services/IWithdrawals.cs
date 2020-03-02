using ATM.Models;

namespace ATM.Interfaces.Services
{
    public interface IWithdrawals
    {
        /// <summary>
        /// Request a withdrawal
        /// </summary>
        /// <param name="amount">value to be requested</param>
        /// <returns></returns>
        Withdraw DoWithdrawal(int amount);
    }
}