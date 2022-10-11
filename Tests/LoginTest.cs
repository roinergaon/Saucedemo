using saucedemo.PageObjects;
using Mypro.PageObjects;
using NUnit.Framework;

namespace saucedemo.Tests
{
    [TestFixture]
    class LoginTest : BaseTest
    {

        [Test]
        public void TC01_loginFailed1()
        {
            LoginPage lp = new LoginPage(driver);
            //PageFactory.InitElements(driver, lp);
            lp.Login("standard_user1", "");
            string expected = "Epic sadface: Password is required";
            string actual = lp.GetErrorMsg();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TC02_loginFailed()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret");
            string expected = "Epic sadface: Username and password do not match any user in this service";
            string actual = lp.GetErrorMsg();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void TC03_loginFailed()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("Roi", "123456");
            string expected = "Epic sadface: Username and password do not match any user in this service";
            string actual = lp.GetErrorMsg();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TC04_loginSucceed()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login("standard_user", "secret_sauce");
            string expected = "PRODUCTS";
            ProductsPage Prodacts_Page = new ProductsPage(driver);
            string actual = lp.GetrightEnteredPage(Prodacts_Page.rightEnteredPage_Products);
            Assert.AreEqual(actual, expected);
        }

       
    }
}
