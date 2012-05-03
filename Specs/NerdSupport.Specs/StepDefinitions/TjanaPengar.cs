using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nerdsupport.Specs.Automation;
using TechTalk.SpecFlow;
using NerdSupport.Domain.Model;

namespace NerdSupport.Specs.StepDefinitions
{
    [Binding]
    public class TjanaPengar : StepDefinition
    {
        [Given(@"att nörden har 99kr")]
        public void GivetAttNordenHar99Kr()
        {
            var nord = New<Nord>().With(n => n.Plånbok, 99).Create();

            InjectPreconditions(nord);
        }

        [When(@"nörden svarar på en fråga")]
        public void NarNordenSvararPaEnFraga()
        {
            _arbetsflode.OppnaNastaFraga().BesvaraFraga("bla bla bla bla bla");
        }

        [Then(@"ska nörden ha 100kr")]
        public void SaSkaNordenHa100Kr()
        {
            _arbetsflode.KontrolleraPengar(100);
        }

    }
}
