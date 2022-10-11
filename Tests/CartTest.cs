using saucedemo.PageObjects;
using Mypro.PageObjects;
using NUnit.Framework;


namespace saucedemo.Tests
{
    [TestFixture]
    class CartTest : BaseTest

    {

        [Test, Description("add producat Sause Labs Bolt T- Shirt to the Cart")]
        public void TC01_addProduct()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Bolt T-Shirt");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Backpack");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Onesie");
            Prodacts_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Bolt T-Shirt");
            MyCart.VerifyProductsNames("Sauce Labs Backpack");
            MyCart.VerifyProductsNames("Sauce Labs Onesie");
            //Prodacts_Page.chooseProduct("Sauce Labs Backpack");
            //Prodacts_Page.chooseProduct("Sauce Labs Onesie");
            //psp.GetrightEnteredPage(psp.rightEnteredPage_Product);
            //ProductPage Product_Page = new ProductPage(driver);
            //string expected = "Sauce Labs Bolt T-Shirt";
            //string actual = Product_Page.GetChoosenValueName();
            //Assert.AreEqual(actual, expected);
            //Product_Page.AddToCart();
            //Product_Page.click(Product_Page.myCart);
        }

        [Test]
        public void TC02_removeProduct()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Bolt T-Shirt");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Backpack");
            Prodacts_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.RemoveProduct("Sauce Labs Bolt T-Shirt");
            MyCart.RemovalValidation("Sauce Labs Bolt T-Shirt");


        }
    }
}