using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Model;
using Microsoft.Practices.Unity;
using NerdSupport.Domain.Repositories;

namespace NerdSupport.Domain.Factories
{
    public class AvtalsFactory : IFactory<ServiceAvtal>
    {
        private readonly IUnityContainer _container;
        private readonly IRepository<ServiceAvtal> _repository;

        public AvtalsFactory(IUnityContainer container, IRepository<ServiceAvtal> repository)
        {
            _container = container;
            _repository = repository;
        }

        public ServiceAvtal Skapa()
        {
            return new ServiceAvtal();
        }

        public ServiceAvtal Hamta(long id)
        {
            var avtal = _repository.GetById(id);

            if (avtal == null)
                return Skapa();

            for (int i = avtal.ServiceRegler.Count - 1; i >= 0; i--)
            {
                var regel = avtal.ServiceRegler[i];
                var namn = regel.Namn;
                var farg = regel.Farg;
                var prio = regel.Prioritet;
                var regelId = regel.Id;

                avtal.ServiceRegler[i] = _container.Resolve<SLARegel>(namn);
                avtal.ServiceRegler[i].Namn = namn;
                avtal.ServiceRegler[i].Farg = farg;
                avtal.ServiceRegler[i].Prioritet = prio;
                avtal.ServiceRegler[i].Id = regelId;
            }

            return avtal;
        }
    }
}
