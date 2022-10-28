using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.All_Locators;

namespace SpecFlowProject1.Page_Objects
{
    public class SearchPhone
    {
        public IWebDriver driver;
        public SearchPhone()
        {
            driver = Hook.driver;
        }
        public void homePage()
        {
            driver.Navigate().GoToUrl(Locators.Url);
            driver.Manage().Window.Maximize();
        }
        public void clickBuyPhone()
        {
            driver.FindElement(Locators.ChoosePhone).Click();
        }
    }
}
