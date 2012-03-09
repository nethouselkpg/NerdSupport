using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Infrastructure.Bus
{
    public interface IMessageBus
    {
        void Publish<T>(T eventMessage);
    }
}
