using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class Avsandare
    {
        public long Id { get; set; }

        public ServiceAvtal ServiceAvtal
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool IsVip { get; set; }

    }
}
