using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public class Nord : IAggregateRoot
    {
        public long Id { get; set; }

        public string Namn { get; set; }

        public int Plånbok { get;
            set;
        }
    }
}
