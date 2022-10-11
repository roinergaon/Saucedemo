using saucedemo.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Mypro.PageObjects
{
    class ProductPage : MenuPage
    {
        [FindsBy(How = How.CssSelector, Using = "[class = 'inventory_details_name large_size']")]
        public IWebElement rightEnteredPage_Product;
        [FindsBy(How = How.CssSelector, Using = ".btn.btn_primary.btn_small.btn_inventory")]
        public IWebElement addToCart;
        [FindsBy(How = How.CssSelector, Using = ".btn.btn_secondary.back.btn_large.inventory_details_back_button")]
        public IWebElement backToProducts;


        public ProductPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetChoosenValueName()
        {
            return GetText(rightEnteredPage_Product);
        }

        public void AddToCart()
        {
            Click(addToCart);
        }

        public void Back()
        {
            Click(backToProducts);
        }



            
    }
}
