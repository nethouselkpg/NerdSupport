using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public class ServiceAvtal : IAggregateRoot
    {
        public long Id { get; set; }

        public List<SLARegel> ServiceRegler
        {
            get;
            set;
        }
    }
}
