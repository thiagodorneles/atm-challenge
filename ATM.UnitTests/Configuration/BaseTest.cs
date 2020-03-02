using System;
using ATM.DependencyInjection;

namespace ATM.UnitTests
{
    public class BaseTest
    {
        protected BaseTest()
        {
            Bootstrap.RegisterModules();
        }
    }
}