using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class AttaTimmarsRegel : SLARegel
    {
        public override bool Uppfyller(Fraga arende)
        {
            return arende.Inskickad.AddHours(-8) < DateTime.Now;
        }
    }
}
