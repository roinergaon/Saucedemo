using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace saucedemo.PageObjects

{
    class LoginPage : BasePage 

    {

        [FindsBy(How = How.CssSelector, Using = "#user-name")]
        private IWebElement userField;
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement passwordField;
        [FindsBy(How = How.CssSelector, Using = "#login-button")]
        private IWebElement loginBtn;
        [FindsBy(How = How.CssSelector, Using = "[data-test='error']")]
        private IWebElement errorLable;
        [FindsBy(How = How.CssSelector, Using = ".submit-button.btn_action")]
        public IWebElement loginButton;



        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        public void Login(String user, String password)
        {
            //PageFactory.InitElements(driver, this);
            FillText(userField, user);
            FillText(passwordField, password);
            Click(loginBtn);
        }

        

        public String GetErrorMsg()
        {
            return GetText(errorLable);
        }

        //Validation
        //public string GetrightEnteredPage()
        //{
        //    return GetText(rightEnteredPage_Products);
        //}
    }
}
