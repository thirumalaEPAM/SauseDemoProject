using OpenQA.Selenium;
using ProjectPOMframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilitiesframework
{
   
    public class LoginHelper
    {
        LoginPage loginPage;
        IWebDriver webdriver;
        Utitlities ob;
        public void Login(String userName, String password)
        {
            ob = new Utitlities(webdriver);
            loginPage = new LoginPage();
            ob.SendText(loginPage.elementUsename, userName);
            ob.SendText(loginPage.elementPassword, password);

        }

        public LoginHelper(IWebDriver driver)
        {
            this.webdriver = driver;
        }
    }
}
