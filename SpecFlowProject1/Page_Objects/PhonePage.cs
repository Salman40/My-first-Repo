using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.All_Locators;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using SpecFlowProject1.Assertions;

namespace SpecFlowProject1.Page_Objects
{
    public class PhonePage
    {
        public IWebDriver driver;
        public IAlert alert;
        
        public PhonePage()
        {
            driver = Hook.driver;

        }
        public void PhoneName()
        {
            var productName = driver.FindElement(Locators.pName);
            Assertion.myAssert(productName.Text, Locators.txt);
            //Assert.AreEqual(Locators.txt, productName.Text);
            //Console.WriteLine("Phone Name is showing correctly, so it has Passed.");
        }
        public void PhonePrice()
        {
            var productPrice = driver.FindElement(Locators.pPrice);
            Assertion.myAssert(productPrice.Text,Locators.price );
            //Assert.AreEqual(Locators.price, productPrice.Text);
            //Console.WriteLine("Phone Price is showing correctly, so it has Passed.");
        }
        public void addToCart()
        {
            driver.FindElement(Locators.AddCartButton).Click();
            Sleep(4000);
        }
        public void handleAlert()
        {
            alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        public void GoToCart()
        {
            driver.FindElement(Locators.cart).Click();
        }
        public void Sleep(int sleepTime)
        {
            Thread.Sleep(sleepTime);
        }
    }
}
