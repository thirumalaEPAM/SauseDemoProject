using OpenQA.Selenium;
using ProjectPOMframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilitiesframework
{
    public class ProductsHelper
    {
        ProductsPage productsPage;
        IWebDriver webdriver;
        Utitlities ob;

        public Boolean Procutsavalability()
        {
            ob = new Utitlities(webdriver);
            productsPage = new ProductsPage();
            int ProductCount = ob.getNumProdcts(productsPage.elementItemName);
            if (ProductCount != 0) return true;
            else return false;
        }
        public ProductsHelper(IWebDriver driver)
        {
            this.webdriver = driver;
        }
    }
}
