using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Factories;
using NerdSupport.Domain.Model;

namespace NerdSupport.Domain.Services
{
    public class PrioriteringsService : IPrioriteringsService
    {
        private IFactory<ServiceAvtal> _avtalsFactory;

        public PrioriteringsService(IFactory<ServiceAvtal> avtalsFactory)
        {
            _avtalsFactory = avtalsFactory;
        }

        public int Prioritera(Fraga fraga)
        {
            var avtal = _avtalsFactory.Hamta(fraga.Avsandare.ServiceAvtalId);
            int prioritet = 0;

            foreach (var regel in avtal.ServiceRegler)
            {
                if (!regel.Uppfyller(fraga))
                {
                    prioritet += regel.Prioritet;
                }
            }

            return prioritet;
        }
    }
}
