using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V104.Network;
using SpecFlowProject1.All_Locators;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Page_Objects
{
    public class OrderPage
    {
        public IWebDriver driver;
        public OrderPage()
        {
            driver = Hook.driver;
        }
        public void placeOrder()
        {
            driver.FindElement(Locators.PlaceOrderButton).Click();
        }
        public void fillAddress()
        {
            driver.FindElement(Locators.NameField).SendKeys("Salman");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Locators.CountryField).SendKeys("India");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Locators.CityField).SendKeys("Shahjahanpur");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Locators.CardField).SendKeys("Visa Card");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Locators.MonthField).SendKeys("October");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Locators.YearField).SendKeys("2022");
        }
        public void purchase()
        {
            driver.FindElement(Locators.purchaseButton).Click();
        }
        public void Sleep(int sleepTime)
        {
            Thread.Sleep(sleepTime);
        }
    }
    
}
