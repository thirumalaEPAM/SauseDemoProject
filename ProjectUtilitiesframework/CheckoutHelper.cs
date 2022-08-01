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
        CheckOutPage checkOutPage;
        IWebDriver webdriver;
        Utitlities ob;
        public void userDetailsEntry()
        {
            ob = new Utitlities(webdriver);
            checkOutPage = new CheckOutPage();
            ob.SendText(checkOutPage.elementFirstName, Constants.userFirstName);
            ob.SendText(checkOutPage.elementLastName, Constants.lastName);
            ob.SendText(checkOutPage.elementZipCode, Constants.pin);
        }

        public CheckoutHelper(IWebDriver driver)
        {
            this.webdriver = driver;
        }
    }
}
