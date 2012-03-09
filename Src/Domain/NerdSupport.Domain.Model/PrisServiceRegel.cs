using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class PrisServiceRegel : ServiceRegel
    {
        public override PrioriteringsKlassifikation Uppfyller(Arende arende)
        {
            return PrioriteringsKlassifikation.Empty();
        }
    }
}
