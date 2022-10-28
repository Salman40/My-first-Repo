using OpenQA.Selenium;


namespace SpecFlowProject1.All_Locators
{ 
    
    public static class Locators
    {
        public static string Url = "https://www.demoblaze.com/";
        public static string txt = "Samsung galaxy s6";
        public static string price = "$360 *includes tax";
        public static By pName = By.ClassName("name");
        public static By pPrice = By.ClassName("price-container");
        public static By ChoosePhone = By.XPath("//a[normalize-space()='Samsung galaxy s6']");
        public static By AddCartButton = By.LinkText("Add to cart");
        public static By cart = By.Id("cartur");
        public static By PlaceOrderButton = By.XPath("(//button[normalize-space()='Place Order'])[1]");
        public static By purchaseButton = By.XPath("//button[normalize-space()='Purchase']");
        public static By NameField = By.Id("name");
        public static By CountryField = By.Id("country");
        public static By CityField = By.Id("city");
        public static By CardField = By.Id("card");
        public static By MonthField = By.Id("month");
        public static By YearField = By.Id("year");
    }
}
