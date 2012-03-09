using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace NerdSupport.Infrastructure.Configuration
{
    public class ControllerActivator : IControllerActivator
    {

        IController IControllerActivator.Create(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return DependencyResolver.Current.GetService(controllerType) as IController;
        }
    }
}