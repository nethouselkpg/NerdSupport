using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class PrioriteringsKlassifikation
    {
        public long Id { get; set; }

        public string Farg { get; set; }

        public int Prioritet { get; set; }

        public static PrioriteringsKlassifikation Empty()
        {
            return new PrioriteringsKlassifikation { Prioritet = 0 };
        }
    }
}
