using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumTest.Helper
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void RunBeforeScenario()
        {
            DriverClass.BrowserInstance();
        }

        [AfterScenario]
        public void RunAfterScenario()
        {
            DriverClass.CloseBrowser();
        }
    }
}
