using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Repositories;
using NerdSupport.Domain.Services;

namespace NerdSupport.Domain.Factories
{
    public class FrageKoFactory : IFactory<FrageKo>
    {
        private readonly IRepository<Fraga> _frageRepository;
        private readonly IPrioriteringsService _prioService;

        public FrageKoFactory(IRepository<Fraga> frageRepository, IPrioriteringsService prioService)
        {
            _frageRepository = frageRepository;
            _prioService = prioService;
        }
        public FrageKo Skapa()
        {
            var fragor = _frageRepository.GetAll();

            foreach(var fraga in fragor)
            {
                fraga.Prioritet = _prioService.Prioritera(fraga);
            }

            var frageKo = new FrageKo(fragor.ToList());
            return frageKo;
        }

        public FrageKo Hamta(long id)
        {
            throw new NotImplementedException();
        }
    }
}
