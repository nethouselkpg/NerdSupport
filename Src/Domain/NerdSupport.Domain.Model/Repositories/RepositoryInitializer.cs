using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace NerdSupport.Domain.Repositories
{
    public static class RepositoryInitializer
    {
        public static void Init()
        {
            Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }
    }
}
