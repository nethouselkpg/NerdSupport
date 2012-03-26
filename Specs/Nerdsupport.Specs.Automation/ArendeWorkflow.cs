using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using WatiN.Core.Constraints;
using SHDocVw;
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

        public NordWorkflow KontrolleraTitel(string expectedTitel)
        {
            var titel = Browser.Page<StartPage>().FrågeTitel.InnerHtml.Trim();
            Assert.AreEqual(expectedTitel, titel);
            return this;
        }
    }
}
