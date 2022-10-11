using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace saucedemo.PageObjects
{
    public class BasePage
    {
        

        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void FillText(IWebElement el, String text)
        {
            el.Clear();
            el.SendKeys(text);
        }

        public void Click(IWebElement el)
        {
            el.Click();
        }

        public string GetText(IWebElement el)
        {
         return el.Text;
        }

        public string GetrightEnteredPage(IWebElement el)
        {
            return GetText(el);
        }

        public bool IsDisplay(IWebElement el)
        {
            return el.Displayed;
        }

        public void DeleteField(IWebElement el)
        {
            el.Clear();
        }



    }
}
