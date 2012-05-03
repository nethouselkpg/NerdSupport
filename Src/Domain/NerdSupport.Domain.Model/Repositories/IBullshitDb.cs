using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model.Repositories
{
    public interface IBullshitDb<T> where T : class, IAggregateRoot
    {
        List<T> Alla { get; set; }
    }
}
