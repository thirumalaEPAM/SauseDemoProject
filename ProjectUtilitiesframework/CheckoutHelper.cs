using OpenQA.Selenium;
using ProjectPOMframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilitiesframework
{
    public class CheckoutHelper
    {
        IWebDriver webdriver;
        Utitlities ob;
        public void userDetailsEntry()
        {           
           
            ob.SendText(CheckOutPage.elementFirstName, Constants.userFirstName);
            ob.SendText(CheckOutPage.elementLastName, Constants.lastName);
            ob.SendText(CheckOutPage.elementZipCode, Constants.pin);
        }

        public CheckoutHelper(IWebDriver driver)
        {
            this.webdriver = driver;
            ob = new Utitlities(webdriver);
        }
    }
}
