using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace Mypro.PageObjects
{
    public class BaseTest
    {
        [FindsBy(How = How.CssSelector, Using = ".shopping_cart_link")]
        public IWebElement myCart;

        public IWebDriver driver;

        [SetUp]
        public virtual void Setup()
        {
            driver = new ChromeDriver(@"C:\webdrivers");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            //driver.Url = "https://www.saucedemo.com/";
            PageFactory.InitElements(driver, this);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
