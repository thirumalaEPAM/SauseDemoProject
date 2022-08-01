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
        
        IWebDriver webdriver;
        Utitlities ob;
        public void Login(String userName, String password)
        {          
           
            ob.SendText(LoginPage.elementUsename, userName);
            ob.SendText(LoginPage.elementPassword, password);

        }

        public LoginHelper(IWebDriver driver)
        {
            this.webdriver = driver;
            ob = new Utitlities(webdriver);
        }
    }
}
