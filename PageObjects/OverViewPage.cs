using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace saucedemo.PageObjects
{
    class OverViewPage : MenuPage
    {
        [FindsBy(How = How.CssSelector, Using = ".summary_subtotal_label")]
        public IWebElement totalPtice;
        [FindsBy(How = How.CssSelector, Using = ".btn.btn_action.btn_medium.cart_button")]
        public IWebElement finishButton;

        public OverViewPage(IWebDriver driver) : base(driver)
        {
        }

        public string ReadTotalPrice()
        {
            return GetText(totalPtice);
        }

        public void ValidatePrice(string price)
        {
            if (!ReadTotalPrice().Contains(price))
                throw new Exception("Total price is wrong");

        }

        public void Finish()
        {
            Click(finishButton);
        }


    }
}
