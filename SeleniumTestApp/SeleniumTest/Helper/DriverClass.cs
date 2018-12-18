using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumTest.Helper
{
    
    public class DriverClass
    {
        public static IWebDriver driver;
        public static void BrowserInstance()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5000);
            driver.Manage().Window.Maximize();
            ScenarioContext.Current.Add("CurrentDriver", driver);
        }

        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
