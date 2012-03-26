using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NerdSupport.Domain.Model;
using TechTalk.SpecFlow.Assist;
using Ploeh.AutoFixture;
using Nerdsupport.Specs.Automation;
using NerdSupport.Infrastructure.Configuration;
using NerdSupport.Domain.Services;
using NerdSupport.Domain.Repositories;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NerdSupport.Specs.StepDefinitions.PrioriteringAvArende
{
    [Binding]
    public class IngaReglerBrutna
    {
        private Fraga _fraga;
        private ServiceAvtal _serviceAvtal;
        private IPrioriteringsService _prioriteringsService;
        private int _prioritet;

        [Given(@"att ett serviceavtal har följande SLA regler")]
        public void GivetAttEttServiceavtalHarFoljandeSLARegler(Table table)
        {
            var fixture = new Fixture();
            
            _serviceAvtal = fixture.CreateAnonymous<ServiceAvtal>();
            _serviceAvtal.ServiceRegler = table.CreateSet<StandardRegel>().Cast<SLARegel>().ToList();

            _fraga = fixture.CreateAnonymous<Fraga>();
            _fraga.Avsandare.ServiceAvtalId = 1;

            var serviceAvtalRepository = new Mock<IRepository<ServiceAvtal>>();
            serviceAvtalRepository.Setup(s => s.GetById(1)).Returns(_serviceAvtal);

            IoC.Init();
            IoC.InjectBinding(typeof(IRepository<ServiceAvtal>), serviceAvtalRepository.Object);
            IoC.Map();
        }

        [Given(@"att inga regler är brutna")]
        public void GivetAttIngaReglerArBrutna()
        {
            _fraga.Inskickad = DateTime.Now;
        }

        [Given(@"att ""8 timmars regeln"" inte uppfylls")]
        public void GivetAtt8TimmarsRegelnInteUppfylls()
        {
            _fraga.Inskickad = DateTime.Now.AddHours(12);
        }

        [Then(@"är frågans prioritet (.*)")]
        public void SaArFragansPrioritet(int expectedPrioritet)
        {
            Assert.AreEqual(expectedPrioritet, _prioritet);
        }

        [Given(@"att ""Dygnsregeln"" inte uppfylls")]
        public void GivetAttDygnsregelnInteUppfylls()
        {
            _fraga.Inskickad = DateTime.Now.AddHours(26);
        }

        [When(@"Systemet beräknar frågans prioritet")]
        public void NarSystemetBeraknarFragansPrioritet()
        {
            _prioriteringsService = IoC.Resolve<IPrioriteringsService>();
            _prioritet = _prioriteringsService.Prioritera(_fraga);
        }
    }
}
