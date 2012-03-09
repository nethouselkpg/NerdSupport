using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class ServiceRegel
    {
        public long Id { get; set; }
        
        public string Namn { get; set; }
        
        public PrioriteringsKlassifikation PrioriteringsKlassifikation
        {
            get;
            set;
        }

        public virtual PrioriteringsKlassifikation Uppfyller(Arende arende) { 
            return PrioriteringsKlassifikation.Empty();
        }
    }
}
