using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Shared;

namespace NerdSupport.Domain.Model
{
    public class ServiceAvtal : IAggregateRoot
    {
        public long Id { get; set; }

        public List<ServiceRegel> ServiceRegler
        {
            get;
            set;
        }

        public void LaggTillServiceRegel(ServiceRegel regel)
        {
            if(ServiceRegler == null)
                ServiceRegler = new List<ServiceRegel>();

            ServiceRegler.Add(regel);
        }

        public PrioriteringsKlassifikation KontrolleraAvtalsRegler(Arende arende)
        {
            var brutnaRegler = BrutnaReglerFor(arende);
            brutnaRegler = brutnaRegler.OrderBy(regel => regel.Prioritet);

            return brutnaRegler.Last();
        }

        private IEnumerable<PrioriteringsKlassifikation> BrutnaReglerFor(Arende arende)
        {
            foreach (var regel in ServiceRegler)
            {
                yield return regel.Uppfyller(arende);
            }
        }
    }
}
