using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProjectPOMframework;

namespace ProjectUtilitiesframework
{
    public class HelperClass
    {
        #region AllPages Instantiation
        Utitlities ob;
        LoginPage loginPage;
        ProductsPage productsPage;
        CheckOutPage checkOutPage;
        MyCartPage myCartPage;
        #endregion
        IWebDriver webdriver;
        
        public void ButtonClick(String buttonName)
        {
            ob = new Utitlities(webdriver);
            loginPage = new LoginPage();
            checkOutPage = new CheckOutPage();
            myCartPage = new MyCartPage();
            productsPage = new ProductsPage();
            if (buttonName == Constants.Login)
                ob.ClickElement(loginPage.elementLogin);

            else if (buttonName == Constants.Addcart) { ob.ClickElement(productsPage.elementAddCart); }
            else if (buttonName == Constants.shipping) { ob.ClickElement(myCartPage.elementShippingCart); }
            else if (buttonName == Constants.checkout) { ob.ClickElement(myCartPage.elementCheckOut); }
            else if (buttonName == Constants.Continue) { ob.ClickElement(checkOutPage.elementContinueBtn); }
            else if(buttonName==Constants.remove) { ob.ClickElement(productsPage.elementRemoveCart); }
            else if (buttonName ==Constants.finish)
            {
                ob.pageScroll(checkOutPage.elementFinish);
                ob.ClickElement(checkOutPage.elementFinish);
            }
            else { Console.WriteLine("button not existed"); }

        }
       
        public int RondomNum()
        {

            Random rnd = new Random();

            return rnd.Next(200, 1000);
        }
        public String getText(string text)
        {
             ob = new Utitlities(webdriver);
            productsPage = new ProductsPage();
             checkOutPage = new CheckOutPage();
            if (text == Constants.remove)
                return ob.getElementText(productsPage.elementRemoveCart);           
            else if (text == Constants.Itemprice) { return ob.getElementText(productsPage.elementItemPrice); }
            else if (text == Constants.ItemName) { return ob.getElementText(productsPage.elementItemName); }
            else if (text == Constants.addcart) { return ob.getElementText(productsPage.elementAddCart); }
            else { return ob.getElementText(checkOutPage.elementCompleteOrder); }
        }    
        public String TakeScreenshot()
        {
            Screenshot screenshot = ((ITakesScreenshot)webdriver).GetScreenshot();
            string path1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net6.0\\", "");
            string path = path1 + "\\Screenshots\\" + RondomNum() + ".png";
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            return path;
        }

      
        public HelperClass(IWebDriver driver)
        {
            this.webdriver = driver;
        }
    }
}
