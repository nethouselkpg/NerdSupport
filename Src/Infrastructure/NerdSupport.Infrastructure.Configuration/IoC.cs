using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using System.Web;
using System.Web.Mvc;
using NerdSupport.Infrastructure.Bus;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Repositories;
using NerdSupport.Domain.Factories;
using System;
using System.Collections.Generic;
using NerdSupport.Domain.Services;

namespace NerdSupport.Infrastructure.Configuration
{
    public static class IoC
    {
        private static IUnityContainer _container;
        private static Dictionary<Type, Type> _overriddenMappings;

        public static IUnityContainer Container { get { return _container; } }

        public static IUnityContainer Init()
        {
            _overriddenMappings = new Dictionary<Type, Type>();
            _container = new UnityContainer();
            return _container;
        }

        public static IUnityContainer Map()
        {
            _container.RegisterType<IControllerActivator, ControllerActivator>();
            _container.RegisterType<IMessageBus, MessageBus>();
            _container.RegisterType<IDataContextFactory, DataContextFactory>();
            _container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            _container.RegisterType(typeof(IFactory<ServiceAvtal>), typeof(AvtalsFactory));
            _container.RegisterType(typeof(IFactory<FrageKo>), typeof(FrageKoFactory));
            _container.RegisterType<IPrioriteringsService, PrioriteringsService>();

            _container.RegisterType<SLARegel, AttaTimmarsRegel>("8 timmars regeln");
            _container.RegisterType<SLARegel, DygnsRegel>("Dygnsregeln");
            _container.RegisterType<SLARegel, StandardRegel>("VIP avsändar regeln");

            _container.RegisterInstance(typeof(IUnityContainer), _container);

            return _container;
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public static void InjectBinding(Type fromType, object @object)
        {
            if (_container.IsRegistered(fromType) && !_overriddenMappings.ContainsKey(fromType))
            {
                _overriddenMappings.Add(fromType, @object.GetType());
            }
            _container.RegisterInstance(fromType, null, @object, new HierarchicalLifetimeManager());
        }

        public static void ResetBindings()
        {
            foreach (var mapping in _overriddenMappings)
            {
                _container.RegisterType(mapping.Key, mapping.Value);
            }
        }


    }
}