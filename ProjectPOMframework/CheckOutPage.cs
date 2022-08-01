using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMframework
{
    public class CheckOutPage
    {
        public static By elementContinueShipping = By.Id("continue-shopping");
        public static By elementFirstName = By.Id("first-name");
        public static By elementLastName = By.Name("lastName");
        public static By elementZipCode = By.Name("postalCode");
        public static By elementContinueBtn = By.Id("continue");
        public static By elementFinish = By.Id("finish");
        public static By elementCompleteOrder = By.XPath("//h2[@class='complete-header']");
    }
}
