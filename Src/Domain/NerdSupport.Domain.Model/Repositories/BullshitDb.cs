using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model.Repositories
{
    public static class BullshitDb<T>
    {
        public static List<T> Alla { get; set; }
    }
}
