using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class SvaraPaFragaCommand
    {
        public int FragaId { get; set; }
        public long NordId { get; set; }
        public string Svar { get; set; }
    }
}
