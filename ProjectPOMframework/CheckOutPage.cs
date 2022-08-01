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
        public By elementContinueShipping = By.Id("continue-shopping");
        public By elementFirstName = By.Id("first-name");
        public By elementLastName = By.Name("lastName");
        public By elementZipCode = By.Name("postalCode");
        public By elementContinueBtn = By.Id("continue");
        public By elementFinish = By.Id("finish");
        public By elementCompleteOrder = By.XPath("//h2[@class='complete-header']");
    }
}
