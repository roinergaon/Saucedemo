using Mypro.PageObjects;
using NUnit.Framework;
using saucedemo.PageObjects;
using System.Threading;

namespace saucedemo.Tests
{
    [TestFixture]

    class AddProductToCartTest : BaseTest
    {

        [Test]

        public void Add_ProductToCartTest()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Bolt T-Shirt");
            Prodacts_Page.OpenLeftMenu();
            Thread.Sleep(1000);
            Prodacts_Page.SaucedemoLogOut();
            bool isDiapley = lp.IsDisplay(lp.loginButton);
            Assert.IsTrue(isDiapley, "Login page not found");
            lp.Login("standard_user", "secret_sauce");
            Prodacts_Page.AddToCartAndSavePrice("Sauce Labs Backpack");
            Prodacts_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Bolt T-Shirt");
            MyCart.VerifyProductsNames("Sauce Labs Backpack");


        }

    }
}
