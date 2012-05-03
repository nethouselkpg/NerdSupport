using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nerdsupport.Specs.Automation
{
    public class NordWorkflow : Workflow
    {
        public NordWorkflow OppnaNastaFraga()
        {
            Browser.GoTo("http://localhost:80/");
            return this;
        }

        public NordWorkflow BesvaraFraga(string svar)
        {
            Browser.Page<StartView>().SvarsRuta.TypeText(svar);
            Browser.Page<StartView>().SvarsKnapp.Click();

            return this;
        }

        public NordWorkflow KontrolleraTitel(string expectedTitel)
        {
            string titel = Browser.Page<StartView>().FrågeTitel.InnerHtml.Trim();

            try
            {
                Assert.AreEqual(expectedTitel, titel);
            }
            catch
            {
                Stäng();
                throw;
            }

            return this;
        }


        public NordWorkflow KontrolleraPengar(int expectedPengar)
        {
            var pengar = Browser.Page<StartView>().AntalPengar.InnerHtml.Trim();

            try
            {
                Assert.AreEqual(expectedPengar, Convert.ToInt16(pengar));
            }
            catch
            {
                Stäng();
                throw;
            }
            return this;
        }
    }
}