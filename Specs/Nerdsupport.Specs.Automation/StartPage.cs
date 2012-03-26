using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

namespace Nerdsupport.Specs.Automation
{
    public class StartPage : Page
    {
        public Element FrågeTitel
        {
            get
            {
                return Document.ElementsWithTag("h1").Filter(Find.ByClass("fraga")).FirstOrDefault();
            }
        }
    }
}
