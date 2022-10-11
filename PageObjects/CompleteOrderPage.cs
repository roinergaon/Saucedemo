using OpenQA.Selenium;
using saucedemo.PageObjects;
using SeleniumExtras.PageObjects;
using System;

namespace ClassLibrary3.PageObjects
{
    class CompleteOrderPage : MenuPage
    {
        [FindsBy(How = How.CssSelector, Using = ".complete-header")]
        private IWebElement orderCompletionMessage;

        public CompleteOrderPage(IWebDriver driver) : base(driver)
        {
        }


        public bool VerifyOrderCompletion()
        {
            if (orderCompletionMessage.Text == "THANK YOU FOR YOUR ORDER")
                return true;
            else
                throw new Exception("Please check your order");
        }
    }
}
