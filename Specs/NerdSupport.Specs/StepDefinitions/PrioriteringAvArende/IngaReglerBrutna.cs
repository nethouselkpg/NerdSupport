using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NerdSupport.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nerdsupport.Specs.Automation;
using Ploeh.AutoFixture;
using Moq;
using NerdSupport.Infrastructure.Configuration;
using NerdSupport.Infrastructure.Repositories;
using Microsoft.Practices.Unity;
using DeleporterCore.Client;

namespace NerdSupport.Specs.StepDefinitions
{
    [Binding]
    public class IngaReglerBrutna
    {
        private ArendeWorkflow _arbetsFlode = new ArendeWorkflow();

        [Given(@"att ett serviceavtal har regler med följande prioritetsklass")]
        public void GivetAttFoljandeReglerArKoppladeTillNethouseAvtal(Table table)
        {
            Deleporter.Run(() =>
            {
                Mock<IRepository<Arende>> repo = new Mock<IRepository<Arende>>(MockBehavior.Strict);
                repo.Setup(r => r.GetAll()).Returns(new List<Arende>() { new Arende { Ankommet = DateTime.Now.AddYears(-102) }});
                IoC.Container.RegisterInstance(typeof(IRepository<Arende>), null, repo.Object, new HierarchicalLifetimeManager());
            });
            
            var serviceRegler = table.CreateSet<PrioriteringsKlassifikation>().ToList();

            ArendeWorkflow arendeWf = new ArendeWorkflow();

            _arbetsFlode.OppnaArendeLista().Close();

        }

        [Given(@"att inga regler är brutna")]
        public void GivetAttIngaReglerArBrutna()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"handläggaren granskar ärendets prioritet")]
        public void NarHandlaggarenGranskarArendetsPrioritet()
        {

        }

        [Then(@"är ärendets prioritetsklassificering 0")]
        public void SaArArendetsPrioritetsklassificeringNollstalld()
        {
            var arende = ScenarioContext.Current.Get<Arende>();
        }
    }
}
