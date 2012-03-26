using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public class Avsandar
    {
        public long Id { get; set; }

        public long ServiceAvtalId
        {
            get;
            set;
        }

        public string Namn { get; set; }

    }
}
