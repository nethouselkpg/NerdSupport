using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Infrastructure.Bus;
using NerdSupport.Domain.Repositories;

namespace NerdSupport.Domain.Model
{
    public class SvaraPaFragaCommandHandler : IConsumer<SvaraPaFragaCommand>
    {
        private readonly IRepository<Fraga> _frageRepository;
        private readonly IMessageBus _messageBus;

        public SvaraPaFragaCommandHandler(IRepository<Fraga> frageRepository, IMessageBus messageBus)
        {
            _frageRepository = frageRepository;
            _messageBus = messageBus;
        }

        public void Handle(SvaraPaFragaCommand eventMessage)
        {
            var fraga = _frageRepository.GetById(eventMessage.FragaId);
            fraga.Svar = eventMessage.Svar;


            _messageBus.Publish(new FragaBesvaradEvent 
            { 
                FragaId = eventMessage.FragaId,
                NordId = eventMessage.NordId,
                Svar = eventMessage.Svar
            });
        }
    }
}
