global using FluentAssertions;
global using NUnit;
global using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.All_Locators;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Page_Objects;


namespace SpecFlowProject1.Assertions
{
    public static class Assertion
    {
        public static void myAssert(string Expected, string Actual)
        {
            
            Assert.AreEqual(Expected, Actual);
            Console.WriteLine("Phone Name is showing correctly, so it has Passed.");
        }
    }
}
