using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Repositories;
using NerdSupport.Infrastructure.Bus;

namespace NerdSupport.Domain.Model
{

    public class TjanaPengar : IConsumer<FragaBesvaradEvent>
    {
        private readonly IRepository<Nord> _repository;

        public TjanaPengar(IRepository<Nord> repository)
        {
            _repository = repository;
        }
        public void Handle(FragaBesvaradEvent eventMessage)
        {
            var nord = _repository.GetById(eventMessage.NordId);
            nord.Plånbok = nord.Plånbok + 1;
        }
    }
}
