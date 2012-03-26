using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Repositories;
using System.Web.Mvc;
using NerdSupport.Infrastructure.Bus;
using Nerdsupport.Infrastructure.Configuration;

namespace NerdSupport.Infrastructure.Configuration
{
    public static class Booter
    {
        public static void Boot()
        {
            var container = IoC.Init();
            IoC.Map();
            BusConfiguration.SetContainer(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            RepositoryInitializer.Init();
            MessageBootstrapper.Init();
            ViewMapper.Map(container);
            
        }
    }
}
