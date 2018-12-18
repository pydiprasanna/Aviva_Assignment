using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Helper;

namespace SeleniumTest.Pages
{
    public class GoogleSearch
    {
        public IWebElement SearchTextBox
        {
            get
            {
                return DriverClass.driver.FindElement(By.Name("q"));
            }
        }
        public ReadOnlyCollection<IWebElement> Result
        {
            get
            {
                return DriverClass.driver.FindElements(By.XPath(".//div[@class='rc']/div[@class='r']/a"));
            }
        }
        public IWebElement SearchButton
        {
            get
            {
                return DriverClass.driver.FindElement(By.Name("btnK"));
            }
        }
    }
}
