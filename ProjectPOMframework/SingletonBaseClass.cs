using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectPOMframework
{
    public class SingletonBaseClass
    {
        private  IWebDriver driver = null;

        private static SingletonBaseClass instance = null;
        /** Private Constuctor **/
        private SingletonBaseClass()
        {
            driver = new ChromeDriver();
        }

        /** Initialize WebDriver**/
        public static SingletonBaseClass getDriverInstance() {
            if (instance == null)
            {
                instance = new SingletonBaseClass();
            }
            return instance;
        }

        /** Get the Driver**/
        public IWebDriver getDriver()
        {
            return driver;
        }
        public void launchBrowser() {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void setSingletonInstanceNull() { instance = null; }

    }
}