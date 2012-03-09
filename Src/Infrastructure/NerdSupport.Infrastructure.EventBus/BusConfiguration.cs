using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace NerdSupport.Infrastructure.Bus
{
    public class BusConfiguration : ISubscriptionService
    {
        private static IUnityContainer _unityContainer;

        public static void SetContainer(IUnityContainer container)
        {
            _unityContainer = container;
        }

        public static void Add<T>()
        {
            var consumerType = typeof(T);

            consumerType.GetInterfaces()
                        .Where(x => x.IsGenericType)
                        .Where(x => x.GetGenericTypeDefinition() == typeof(IConsumer<>))
                        .ToList()
                        .ForEach(x => _unityContainer.RegisterType(x,
                                                                 consumerType,
                                                                 consumerType.FullName));
        }

        public IEnumerable<IConsumer<T>> GetSubscriptions<T>()
        {
            var consumers = _unityContainer.ResolveAll(typeof(IConsumer<T>));
            return consumers.Cast<IConsumer<T>>();
        }
    }
}
