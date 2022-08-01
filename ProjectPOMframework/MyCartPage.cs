using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMframework
{
    public class MyCartPage
    {

        public By elementShippingCart = By.XPath("//a[@class='shopping_cart_link']");
        public By elementCancel = By.Id("cancel");
        /** Checkout data**/
        public By elementCheckOut = By.Id("checkout");
    }
}
