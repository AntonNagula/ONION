using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Domain.Services;
using ONION.Domain.Services;
namespace DependencyInjection.Moduls
{
    public class DomainModul:IModul
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IStudentService, StudentService>(new ContainerControlledLifetimeManager());
        }
    }
}
