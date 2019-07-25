using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using DependencyInjection.Moduls;
using DependencyInjection;
namespace ONION
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            Register<DomainModul>(container);
            Register<InfrustructureModul>(container);
            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModul, new()
        {
            // »нициализируем экземпл€р модул€ и вызываем метод Register, передава€ целевой container 
            // дл€ регистрации зависимостей
            new T().Register(container);
        }
    }
}