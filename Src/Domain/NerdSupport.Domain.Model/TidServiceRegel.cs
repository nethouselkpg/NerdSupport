using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class TidServiceRegel : ServiceRegel
    {
        public override PrioriteringsKlassifikation Uppfyller(Arende arende)
        {
            return arende.Ankommet < DateTime.Now.AddDays(-14) ? 
                this.PrioriteringsKlassifikation : PrioriteringsKlassifikation.Empty();
        }
    }
}
