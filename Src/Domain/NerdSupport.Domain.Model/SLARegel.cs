using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public abstract class SLARegel
    {
        public long Id { get; set; }
        
        public string Namn { get; set; }
        
        public string Farg
        {
            get;
            set;
        }

        public int Prioritet { get; set; }

        public abstract bool Uppfyller(Fraga arende);
    }
}
