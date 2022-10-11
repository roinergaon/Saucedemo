using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace saucedemo.PageObjects
{
    class MenuPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".shopping_cart_link")]
        private IWebElement myCart;
        [FindsBy(How = How.CssSelector, Using = "#react-burger-menu-btn")]
        private IWebElement leftMenue;
        [FindsBy(How = How.CssSelector, Using = "#logout_sidebar_link")]
        private IWebElement logOut;

        public MenuPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenLeftMenu()
        {
            Click(leftMenue);
        }


        public void GoToCart()
        {
            Click(myCart);
        }

        public void LogOut()
        {
            Click(logOut);
        }

        public void SaucedemoLogOut()
        {
            Click(logOut);
        }

    }
}
