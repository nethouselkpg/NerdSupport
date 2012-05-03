using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public class ServiceAvtal : IAggregateRoot
    {
        public ServiceAvtal()
        {
            ServiceRegler = new List<SLARegel>();
        }

        public long Id { get; set; }

        public List<SLARegel> ServiceRegler
        {
            get;
            set;
        }
    }
}
