using ATM.Commom.Extensions;

namespace ATM.Commom.Math
{
    public static class FinancialMath
    {
        /// <summary>
        /// Do a math operation returning the value of division and the mod containing the mod value 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static (short howManyNotes, short RestOfDivision) DivideAndGetMod(int amount, int divisor)
        {
            var howManyNotes = System.Math.DivRem(amount, divisor, out var rest).ToShort();
     
            return (howManyNotes, rest.ToShort());
        }
    }
}