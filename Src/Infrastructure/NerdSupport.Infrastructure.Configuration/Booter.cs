using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Repositories;
using System.Web.Mvc;
using NerdSupport.Infrastructure.Bus;
using Nerdsupport.Infrastructure.Configuration;
using NerdSupport.Domain.Model.Repositories;
using NerdSupport.Domain.Model;

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

            BullshitDb<Fraga>.Alla = new List<Fraga>() { new Fraga 
            { 
                Fråga  = "Varför är vi här idag?",
                Inskickad = DateTime.Now.AddDays(-1),
                Avsandare = new Avsandar {
                    ServiceAvtalId = 1
                }
            }};

            BullshitDb<ServiceAvtal>.Alla = new List<ServiceAvtal>
            {
                new ServiceAvtal {
                    Id = 1,
                    ServiceRegler = new List<SLARegel> {
                        new StandardRegel { Namn = "8 timmars regeln" }
                    }
                }
            };

            BullshitDb<Nord>.Alla = new List<Nord>()
            {
                new Nord { Id = 1 }
            };

        }
    }
}
