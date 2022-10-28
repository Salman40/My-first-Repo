using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hook
    {
        public static IWebDriver driver;
        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver();

        }
        [AfterStep]
        public void delay()
        {
            Thread.Sleep(3000);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}