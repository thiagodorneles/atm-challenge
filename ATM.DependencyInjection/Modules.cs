using Unity;
using Unity.Lifetime;

namespace ATM.DependencyInjection
{
    public static class Modules
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();
        public static void Register<I, T>() where T : I
        {
            UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }
        public static T Resolve<T>()
        {
            return UnityContainer.Resolve<T>();
        }
        
    }
}