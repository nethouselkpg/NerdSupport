using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class DygnsRegel : SLARegel
    {
        public override bool Uppfyller(Fraga arende)
        {
            return arende.Inskickad.AddHours(-24) < DateTime.Now;
        }
    }
}
