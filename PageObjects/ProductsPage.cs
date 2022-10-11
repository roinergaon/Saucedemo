using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using saucedemo.PageObjects;
using SeleniumExtras.PageObjects;

namespace Mypro.PageObjects
{
    class ProductsPage : MenuPage
    {

        List<float> productsPriceList = new List<float>();

        [FindsBy(How = How.CssSelector, Using = ".inventory_item_name")]
        public IList<IWebElement> rightEnteredPage_Product;
        [FindsBy(How = How.CssSelector, Using = "[class='title']")]
        public IWebElement rightEnteredPage_Products;
        [FindsBy(How = How.CssSelector, Using = ".inventory_item")]
        public IList<IWebElement> productsLables;

        public static string productPrice = null;

        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public void ChooseProduct(string name)
        {
            IList<IWebElement> list = rightEnteredPage_Product;
            foreach (IWebElement el in list)
            {
                if (el.Text.Equals(name))
                {
                    Click(el);
                    break;
                }
            }
        }
        public void OpenCart()
        {
            Click(driver.FindElement(By.CssSelector("#shopping_cart_container")));
        }

        public List<float> GetAllPrices()
        {

            IList<IWebElement> list = productsLables;
            foreach (IWebElement el in list)
            {
                string price = el.FindElement(By.CssSelector(".inventory_item_price")).Text;
                float productPrice = float.Parse(price.Remove(0, 1));
                productsPriceList.Add(productPrice);
            }

            return productsPriceList;
        }

        public void ValidatePricesSorted_HighToLow(List<float> prices)
        {

            for (int i = 1; i < prices.Count; i++)
            {
                if (prices[i] > prices[i - 1])
                    throw new Exception("Prices are not sorted");
            }
        }


        public string AddToCartAndSavePrice(String name)
        {
            IList<IWebElement> AllProductsLables = productsLables;
            foreach (IWebElement el in AllProductsLables)
            {
                IWebElement titleE1 = el.FindElement(By.CssSelector(".inventory_item_name"));
                if (titleE1.Text.Equals(name))
                {
                    IWebElement addBtn = el.FindElement(By.CssSelector(".btn_inventory"));
                    Click(addBtn);
                    break;
                }
            }
            return SaveProductsPrice(name);
        }

        public string SaveProductsPrice(String name)
        {

            IList<IWebElement> list = productsLables;
            foreach (IWebElement el in list)
            {
                IWebElement titleE1 = el.FindElement(By.CssSelector(".inventory_item_name"));
                if (titleE1.Text.Equals(name))
                {
                    string price = el.FindElement(By.CssSelector(".inventory_item_price")).Text;
                    productPrice = price.Remove(0, 1);
                    return productPrice;
                }
            }
            return productPrice;
        }

        //Validation
        //public string GetrightEnteredPage()
        //{
        //    return GetText(rightEnteredPage_Product);
        //}



    }

}

