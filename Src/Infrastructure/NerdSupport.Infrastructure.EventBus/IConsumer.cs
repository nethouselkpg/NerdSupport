using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Infrastructure.Bus
{
    public interface IConsumer<T>
    {
        void Handle(T eventMessage);
    }
}
