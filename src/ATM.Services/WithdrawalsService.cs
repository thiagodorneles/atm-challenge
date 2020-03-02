using ATM.Commom.Exceptions;
using ATM.Commom.Math;
using ATM.Common.Exceptions;
using ATM.Models;

namespace ATM.Services
{
    public class WithdrawalsService : Interfaces.Services.IWithdrawals
    {
        public Withdraw DoWithdrawal(int amount)
        {
            if (amount % 10 != 0)
            {
                throw new BaseException(Messages.invalid_amount);
            }

            if (amount < 0)
            {
                throw new BaseException(Messages.negative_value_is_invalid);
            }

            var (hundredNotes, hundredRest) =  FinancialMath.DivideAndGetMod(amount, 100);
            
            var (fiftyNotes, fiftyRest) = FinancialMath.DivideAndGetMod(hundredRest, 50);

            var (twentyNotes, twentyRest) = FinancialMath.DivideAndGetMod (fiftyRest, 20);

            var (tenNotes, _) = FinancialMath.DivideAndGetMod (twentyRest, 10);

            return new Withdraw(tenNotes, twentyNotes, fiftyNotes, hundredNotes);
        }
    }
}