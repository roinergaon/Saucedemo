using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace saucedemo.PageObjects
{
    class CustomerInformationPage : MenuPage
    {
        [FindsBy(How = How.CssSelector, Using = "#first-name")]
        private IWebElement firstName;
        [FindsBy(How = How.CssSelector, Using = "#last-name")]
        private IWebElement lastName;
        [FindsBy(How = How.CssSelector, Using = "#postal-code")]
        private IWebElement zipCode;
        [FindsBy(How = How.CssSelector, Using = "#continue")]
        private IWebElement continueButton;
        [FindsBy(How = How.CssSelector, Using = "div.error-message-container.error > h3")]
        private IWebElement errorLable;



        public CustomerInformationPage(IWebDriver driver) : base(driver)
        {
        }

        public void Continue()
        {
            Click(continueButton);
        }

        public String GetErrorMsg()
        {
            return GetText(errorLable);
        }

        public void ClearField(IWebElement el)
        {
            DeleteField(el);
        }

        public void Fill_CheckOutInformation(string first_Name, string last_Name, string Postal_Code)
        {
            FillText(firstName, first_Name);
            FillText(lastName, last_Name);
            FillText(zipCode, Postal_Code);
        }

    }
}
