using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Page_Objects;
using System;
using TechTalk.SpecFlow;

{

}

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class UserGoToSiteAndPlaceAnOrderOfBuyingPhone_StepDefinitions
    {
        public IWebDriver driver = Hook.driver;
        SearchPhone _SearchPhone = new SearchPhone();
        PhonePage _PhonePage = new PhonePage();
        OrderPage _OrderPage = new OrderPage(); 
             
        [Given(@"I am at Home Page of Site")]
        public void GivenIAmAtHomePageOfSite()
        {
            _SearchPhone.homePage();
        }

        [Given(@"I select Samsung Phone")]
        public void GivenISelectSamsungPhone()
        {
            _SearchPhone.clickBuyPhone();
        }

        [Given(@"Add product to the cart")]
        public void GivenAddProductToTheCart()
        {
            _PhonePage.PhoneName();
            _PhonePage.PhonePrice();
            _PhonePage.addToCart();
            _PhonePage.handleAlert();
        }

        [When(@"I Go to the Cart")]
        public void WhenIGoToTheCart()
        {
             _PhonePage.GoToCart(); 
        }

        [When(@"place the order of Phone")]
        public void WhenPlaceTheOrderOfPhone()
        {
            _OrderPage.placeOrder();
        }

        [Then(@"Fill the details for shipping")]
        public void ThenFillTheDetailsForShipping()
        {
            _OrderPage.fillAddress();
        }

        [Then(@"Click on Purchase Button")]
        public void ThenClickOnPurchaseButton()
        {
            _OrderPage.purchase();
        }

        [Then(@"Close the Browser after done")]
        public void ThenCloseTheBrowserAfterDone()
        {
            driver.Close(); 
        }
    }
}
