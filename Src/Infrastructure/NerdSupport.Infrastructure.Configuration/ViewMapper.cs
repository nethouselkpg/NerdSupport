using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace Nerdsupport.Infrastructure.Configuration
{
    public static class ViewMapper
    {
        public static void Map(IUnityContainer container)
        {
            Mapper.Initialize(conf => {
                conf.ConstructServicesUsing(type => container.Resolve(type));
                conf.AddProfile<ShowArendeProfile>();
            });
            
            Mapper.AssertConfigurationIsValid();
           
        }
    }
}
