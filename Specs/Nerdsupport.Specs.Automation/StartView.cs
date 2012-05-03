using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

namespace Nerdsupport.Specs.Automation
{
    public class StartView : Page
    {
        public Element FrågeTitel
        {
            get
            {
                return Document.ElementsWithTag("h1").Filter(Find.ByClass("fraga")).FirstOrDefault();
            }
        }

        public TextField SvarsRuta
        {
            get
            {
                return Document.TextFields.Filter(Find.ByName("svar")).FirstOrDefault();
            }
        }

        public Button SvarsKnapp
        {
            get
            {
                return Document.Button(Find.ById("svaraKnapp"));
            }
        }

        public Element AntalPengar
        {
            get
            {
                return Document.Element(Find.ById("pengar"));
            }
        }   
    }
}
