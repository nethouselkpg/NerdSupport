using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public abstract class ServiceRegel
    {
        public PrioriteringsKlassifikation PrioriteringsKlassifikation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract bool Uppfylls { get; }
    }
}
