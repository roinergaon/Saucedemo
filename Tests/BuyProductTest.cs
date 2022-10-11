using ClassLibrary3.PageObjects;
using Mypro.PageObjects;
using NUnit.Framework;
using saucedemo.PageObjects;


namespace saucedemo.Tests
{
    class BuyProductTest : BaseTest
    {
        [Test]

        public void TC01_BuyProductTest()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Bolt T-Shirt");
            Prodacts_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Bolt T-Shirt");
            MyCart.Checkout();
            CustomerInformationPage CustomerInformation = new CustomerInformationPage(driver);
            CustomerInformation.Fill_CheckOutInformation("Roi", "Ner", "114");
            CustomerInformation.Continue();
            OverViewPage checkOut = new OverViewPage(driver);
            checkOut.ValidatePrice(ProductsPage.productPrice);
            checkOut.Finish();
            CompleteOrderPage complete = new CompleteOrderPage(driver);
            complete.VerifyOrderCompletion();
        }

        [Test]
        public void TC02_BuyAllProductsTest()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Bolt T-Shirt");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Backpack");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Bike Light");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Fleece Jacket");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Onesie");
            Prodacts_Page.AddToCartAndSavePrice("Test.allTheThings() T-Shirt (Red)");
            Prodacts_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Bolt T-Shirt");
            MyCart.VerifyProductsNames("Sauce Labs Backpack");
            MyCart.VerifyProductsNames("Sauce Labs Bike Light");
            MyCart.VerifyProductsNames("Sauce Labs Fleece Jacket");
            MyCart.VerifyProductsNames("Sauce Labs Onesie");
            MyCart.VerifyProductsNames("Test.allTheThings() T-Shirt (Red)");
            MyCart.Checkout();
            CustomerInformationPage CustomerInformation = new CustomerInformationPage(driver);
            CustomerInformation.Fill_CheckOutInformation("Roi", "Ner", "114");
            CustomerInformation.Continue();
            OverViewPage checkOut = new OverViewPage(driver);
            //checkOut.ValidatePrice(ProductsPage.productPrice);
            checkOut.Finish();
            CompleteOrderPage complete = new CompleteOrderPage(driver);
            complete.VerifyOrderCompletion();
        }
    }
}