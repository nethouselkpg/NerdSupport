using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Factories;
using Moq;
using NerdSupport.Infrastructure.Configuration;
using DeleporterCore.Client;
using Nerdsupport.Specs.Automation;

namespace NerdSupport.Specs.StepDefinitions.VisaFraga
{
    [Binding]
    public class VisaFraga
    {
        private NordWorkflow _arbetsFlode = new NordWorkflow();

        [Given(@"att följande frågor finns")]
        public void GivetAttFoljandeFragorFinns(Table table)
        {
            var fragor = table.CreateSet<Fraga>().ToList();

            Deleporter.Run(() =>
            {
                var frageKoFactory = new Mock<IFactory<FrageKo>>(MockBehavior.Loose);
                frageKoFactory.Setup(r => r.Skapa()).Returns(new FrageKo(fragor));
                IoC.InjectBinding(typeof(IFactory<FrageKo>), frageKoFactory.Object);
            });
        }

        [Then(@"ser nörden frågan om \""(.*)\""")]
        public void SaSerNordenFraganOmHurUttalasAzure(string fragaTitel)
        {
            _arbetsFlode.KontrolleraTitel(fragaTitel).Close();
        }

        [When(@"Nörden navigerar till sidan för att besvara frågor")]
        public void NarNordenNavigerarTillSidanForAttBesvaraFragor()
        {
            _arbetsFlode.OppnaNastaFraga();
        }
    }
}
