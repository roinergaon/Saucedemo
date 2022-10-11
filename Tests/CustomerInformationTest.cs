using Mypro.PageObjects;
using NUnit.Framework;
using saucedemo.PageObjects;


namespace saucedemo.Tests
{
    [TestFixture]
    class CustomerInformationTest : BaseTest
    {
    
        [Test]
        public void TC_01_OpenCustonerInformationPage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");
            string expected = "PRODUCTS";
            ProductsPage Products_Page = new ProductsPage(driver);
            string actual = loginPage.GetrightEnteredPage(Products_Page.rightEnteredPage_Products);
            Assert.AreEqual(actual, expected);


            Products_Page.ChooseProduct("Sauce Labs Backpack");
            ProductPage prodact_Page = new ProductPage(driver);
            string productName = prodact_Page.GetChoosenValueName();
            Assert.AreEqual("Sauce Labs Backpack", productName);
            prodact_Page.AddToCart();
            prodact_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Backpack");
            MyCart.Checkout();

            CustomerInformationPage CustomerInformation = new CustomerInformationPage(driver);
            CustomerInformation.Fill_CheckOutInformation("", "", "");
            CustomerInformation.Continue();
            expected = "Error: First Name is required";
            actual = CustomerInformation.GetErrorMsg();
            Assert.AreEqual(actual, expected);

          
        }

        [Test]

        public void TC_02_WrongValues_fail()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");
            string expected = "PRODUCTS";
            ProductsPage Products_Page = new ProductsPage(driver);
            string actual = loginPage.GetrightEnteredPage(Products_Page.rightEnteredPage_Products);
            Assert.AreEqual(actual, expected);


            Products_Page.ChooseProduct("Sauce Labs Backpack");
            ProductPage prodact_Page = new ProductPage(driver);
            string productName = prodact_Page.GetChoosenValueName();
            Assert.AreEqual("Sauce Labs Backpack", productName);
            prodact_Page.AddToCart();
            prodact_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Backpack");
            MyCart.Checkout();

            CustomerInformationPage CustomerInformation = new CustomerInformationPage(driver);
            CustomerInformation.Fill_CheckOutInformation("Roi", "", "");
            CustomerInformation.Continue();
            expected = "Error: Last Name is required";
            actual = CustomerInformation.GetErrorMsg();
            Assert.AreEqual(actual, expected);

        }

        [Test]

        public void TC_03_WrongValues_fail()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");
            string expected = "PRODUCTS";
            ProductsPage Products_Page = new ProductsPage(driver);
            string actual = loginPage.GetrightEnteredPage(Products_Page.rightEnteredPage_Products);
            Assert.AreEqual(actual, expected);


            Products_Page.ChooseProduct("Sauce Labs Backpack");
            ProductPage prodact_Page = new ProductPage(driver);
            string productName = prodact_Page.GetChoosenValueName();
            Assert.AreEqual("Sauce Labs Backpack", productName);
            prodact_Page.AddToCart();
            prodact_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Backpack");
            MyCart.Checkout();

            CustomerInformationPage CustomerInformation = new CustomerInformationPage(driver);
            CustomerInformation.Fill_CheckOutInformation("", "Ner", "");
            CustomerInformation.Continue();
            expected = "Error: First Name is required";
            actual = CustomerInformation.GetErrorMsg();
            Assert.AreEqual(actual, expected);

        }

        [Test]

        public void TC_04_WrongValues_fail()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");
            string expected = "PRODUCTS";
            ProductsPage Products_Page = new ProductsPage(driver);
            string actual = loginPage.GetrightEnteredPage(Products_Page.rightEnteredPage_Products);
            Assert.AreEqual(actual, expected);


            Products_Page.ChooseProduct("Sauce Labs Backpack");
            ProductPage prodact_Page = new ProductPage(driver);
            string productName = prodact_Page.GetChoosenValueName();
            Assert.AreEqual("Sauce Labs Backpack", productName);
            prodact_Page.AddToCart();
            prodact_Page.GoToCart();
            MyCartPage MyCart = new MyCartPage(driver);
            MyCart.VerifyProductsNames("Sauce Labs Backpack");
            MyCart.Checkout();

            CustomerInformationPage CustomerInformation = new CustomerInformationPage(driver);
            CustomerInformation.Fill_CheckOutInformation("Roi", "Ner", "");
            CustomerInformation.Continue();
            expected = "Error: Postal Code is required";
            actual = CustomerInformation.GetErrorMsg();
            Assert.AreEqual(actual, expected);

        }
    }
}