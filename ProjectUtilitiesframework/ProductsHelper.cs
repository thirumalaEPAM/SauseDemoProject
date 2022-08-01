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
        
        IWebDriver webdriver;
        Utitlities ob;

        public Boolean Procutsavalability()
        {          
            
            int ProductCount = ob.getNumProdcts(ProductsPage.elementItemName);
            if (ProductCount != 0) return true;
            else return false;
        }
        public ProductsHelper(IWebDriver driver)
        {
            this.webdriver = driver;
            ob = new Utitlities(webdriver);
        }
    }
}
