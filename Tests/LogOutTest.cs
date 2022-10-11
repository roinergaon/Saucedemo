using Mypro.PageObjects;
using NUnit.Framework;
using saucedemo.PageObjects;
using System.Threading;

namespace ClassLibrary3.Tests

{
    class LogOutTest : BaseTest
    {

        [Test]
        public void LogOut()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            string expected = "PRODUCTS";
            string actual = Prodacts_Page.GetrightEnteredPage(Prodacts_Page.rightEnteredPage_Products);
            Assert.AreEqual(actual, expected);

            Prodacts_Page.OpenLeftMenu();
            Thread.Sleep(1000); 
            Prodacts_Page.SaucedemoLogOut();

            bool isDiapley = lp.IsDisplay(lp.loginButton);
            Assert.IsTrue(isDiapley, "Login page not found");


        }
    }
}
