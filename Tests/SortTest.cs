using Mypro.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using saucedemo.PageObjects;

namespace saucedemo.Tests

{
    [TestFixture]
    class AddProductToCartTest2 : BaseTest
    {

        [Test]
        public void TC01_sort()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Products_Page = new ProductsPage(driver);
            SelectElement oSelect = new OpenQA.Selenium.Support.UI.SelectElement(driver.FindElement(By.CssSelector(".product_sort_container")));

            oSelect.SelectByValue("hilo");

            System.Collections.Generic.List<float> productsPriceList = Products_Page.GetAllPrices();
            Products_Page.ValidatePricesSorted_HighToLow(productsPriceList);
        }


       

    }
}
