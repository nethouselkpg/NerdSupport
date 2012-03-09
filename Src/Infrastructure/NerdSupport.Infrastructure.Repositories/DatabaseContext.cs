using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using NerdSupport.Domain.Model;

namespace NerdSupport.Infrastructure.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Arende> Arende { get; set; }
        public DbSet<ServiceAvtal> ServiceAvtal { get; set; }


        public DatabaseContext()
            : base("DatabaseContext")
        { 
        
        }
    }
}
