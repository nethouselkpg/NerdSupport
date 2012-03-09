using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Infrastructure.Repositories
{
    public interface IDataContextFactory
    {
        DatabaseContext Get();
    }
}
