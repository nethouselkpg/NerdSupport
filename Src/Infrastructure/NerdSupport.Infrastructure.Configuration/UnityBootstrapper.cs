using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using System.Web;
using System.Web.Mvc;
using NerdSupport.Infrastructure.Bus;
using NerdSupport.Infrastructure.Repositories;
using NerdSupport.Domain.Model;

namespace NerdSupport.Infrastructure.Configuration
{
    public static class IoC
    {
        private static IUnityContainer _container;

        public static IUnityContainer Container { get { return _container; } }

        public static void Init()
        {
            _container = BuildUnityContainer();
            BusConfiguration.SetContainer(_container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(_container));
            
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IControllerActivator, ControllerActivator>();
            container.RegisterType<IMessageBus, MessageBus>();
            container.RegisterType<IDataContextFactory, DataContextFactory>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));

            return container;
        }
    }
}