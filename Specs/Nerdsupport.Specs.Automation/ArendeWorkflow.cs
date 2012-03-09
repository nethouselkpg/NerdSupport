using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using WatiN.Core.Constraints;
using SHDocVw;

namespace Nerdsupport.Specs.Automation
{
    public class ArendeWorkflow : Workflow
    {
        public ArendeWorkflow OppnaArendeLista()
        {

            Browser.GoTo("http://localhost:80/");

             
            return this;
            


        }
    }
}
