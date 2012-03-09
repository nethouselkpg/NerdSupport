using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

namespace Nerdsupport.Specs.Automation
{
    public class Workflow
    {
        private Browser _browser;

        public Browser Browser
        {
            get
            {
                if (_browser == null)
                    _browser = new IE();

                return _browser;
            }
        }

        public void Close()
        {
            _browser.Dispose();
            _browser = null;
        }
    }
}
