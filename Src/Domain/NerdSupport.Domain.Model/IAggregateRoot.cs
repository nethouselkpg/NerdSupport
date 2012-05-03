using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public interface IAggregateRoot
    {
        long Id { get; set; }
    }
}
