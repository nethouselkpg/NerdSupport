using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NerdSupport.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NerdSupport.Specs.StepDefinitions
{
    [Binding]
    public class IngaReglerBrutna
    {
        [Given(@"att följande regler är kopplade till Nethouse avtal")]
        public void GivetAttFoljandeReglerArKoppladeTillNethouseAvtal(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"att inga regler är brutna")]
        public void GivetAttIngaReglerArBrutna()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"handläggaren granskar ärendets prioritet")]
        public void NarHandlaggarenGranskarArendetsPrioritet()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"är ärendets prioritetsklassificering nollställd")]
        public void SaArArendetsPrioritetsklassificeringNollstalld()
        {
            var arende = ScenarioContext.Current.Get<Arende>();
            Assert.AreEqual(null, arende.BeraknadPrioritet);
        }
    }
}
