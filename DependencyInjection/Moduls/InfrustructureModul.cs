using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using ONION.InfrastructureServices;
using ONION.Infrustructure.Interfaces;
namespace DependencyInjection.Moduls
{
    public class InfrustructureModul:IModul
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IStudentRepository,StudentRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
