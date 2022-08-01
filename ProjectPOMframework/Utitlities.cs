using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMframework
{
    public class Utitlities
    {
        IWebDriver webdriver;      

        public IWebElement WaitForElement(By elt)
        {

            WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(5));
            return wait.Until(X => X.FindElement(elt));
        }

        public String getElementText(By elt)
        {

            return WaitForElement(elt).Text.ToString();
        }

        public void SendText(By elt, String text)
        {

            WaitForElement(elt).SendKeys(text);

        }

        public int getNumProdcts(By elt)
        {
            ReadOnlyCollection<IWebElement> prodcts = webdriver.FindElements(elt);

            int Count = prodcts.Count();
            return Count;
        }

        public void ClickElement(By elt)
        {
            WaitForElement(elt).Click();
        }

        public void pageScroll(By elt)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webdriver;
            js.ExecuteScript("window.scrollBy(0, 250)", "");


        }
        public Utitlities(IWebDriver driver) { this.webdriver = driver; }
    }
}
