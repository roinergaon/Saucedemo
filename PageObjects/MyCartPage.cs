using saucedemo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using SeleniumExtras.PageObjects;
using System.Collections.ObjectModel;

namespace Mypro.PageObjects
{
    class MyCartPage : MenuPage
    {
        [FindsBy(How = How.CssSelector, Using = ".inventory_item_name")]
        private IList<IWebElement> cartProducts;
        [FindsBy(How = How.CssSelector, Using = "#checkout")]
        private IWebElement checkOut;
        [FindsBy(How = How.CssSelector, Using = ".btn.btn_secondary.btn_small.cart_button")]
        private IWebElement removeFromCart;
        [FindsBy(How = How.CssSelector, Using = ".cart_item_label")]
        private IList<IWebElement> cartItem;

        public MyCartPage(IWebDriver driver) : base(driver)
        {
        }

        public bool VerifyProductsNames(string productName)
        {
            IList<IWebElement> list = cartProducts;
            foreach (IWebElement el in list)
            {
                if (el.Text.Equals(productName))
                    return true;
            }
            throw new Exception("CART doesn't contain :" + productName);
        }


        public void RemovalValidation(string productName)
        {
            IList<IWebElement> cartProducts_list = cartProducts;
            foreach (IWebElement el in cartProducts_list)
            {
                if (el.Text.Equals(productName))
                    throw new Exception(productName + " : wasn't removed from cart page");
            }
        }

        public void Checkout()
        {
            Click(checkOut);
        }




        public void RemoveProduct(string productName)
        {

            IList<IWebElement> cartProducts_lables = cartItem;
            foreach (IWebElement el in cartProducts_lables)
            {
                IWebElement titleE1 = el.FindElement(By.CssSelector(".inventory_item_name"));
                if (titleE1.Text.Equals(productName))
                {
                    el.FindElement(By.CssSelector(".btn.btn_secondary.btn_small.cart_button")).Click();
                }
            }


        }
    }
}
