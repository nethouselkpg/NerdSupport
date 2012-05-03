using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Infrastructure.Bus;
using NerdSupport.Domain.Model;

namespace NerdSupport.Infrastructure.Configuration
{
    public static class MessageBootstrapper
    {
        public static void Init()
        { 
            BusConfiguration.Add<SvaraPaFragaCommandHandler>();
            BusConfiguration.Add<TjanaPengar>();
        }
    }
}
