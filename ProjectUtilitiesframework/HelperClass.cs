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
        #endregion
        IWebDriver webdriver;

        public void ButtonClick(By by)
        {
            ob.ClickElement(by);
        }

        public int RondomNum()
        {

            Random rnd = new Random();

            return rnd.Next(200, 1000);
        }
        /// <summary>
        /// Get the Web Element Text
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public string GetText(By by)
        {
            try { return ob.getElementText(by); }
            catch { return "NotMatch"; }
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
            ob = new Utitlities(webdriver);
        }
    }
}
