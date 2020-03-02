using System;

namespace ATM.Common.Exceptions
{
    public class BaseException : Exception
    {
        public BaseException(string message) : base(message) 
        {
        }
    }
}