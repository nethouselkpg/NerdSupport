using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public class StandardRegel : SLARegel
    {
        public override bool Uppfyller(Fraga arende)
        {
            return true;
        }
    }
}
