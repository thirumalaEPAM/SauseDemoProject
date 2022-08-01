using System;
using TechTalk.SpecFlow;
using ProjectUtilitiesframework;
using ProjectPOMframework;
using NUnit.Framework;

namespace ProjectBDDTestframeWork.StepDefinitions
{
    [Binding]
    public class LoginPageValidationStepDefinitions
    {
        HelperClass help;
        LoginHelper loginHelper;
        ProductsHelper productsHelper;
        [Given(@"Enter the Demo user name ""([^""]*)"" and Password ""([^""]*)""")]
        public void GivenEnterTheDemoUserNameAndPassword(string p0, string p1)
        {
            loginHelper = new LoginHelper(BddHooks.driver);
            loginHelper.Login(p0, p1);
        }

        [Given(@"Enter the Demo user name (.*) and Passw (.*)")]
        public void GivenEnterTheDemoAnd(string p0, string p1)
        {
                loginHelper = new LoginHelper(BddHooks.driver);
                loginHelper.Login(p0, p1);

        }

            [Given(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string username, string password)
        {
            loginHelper = new LoginHelper(BddHooks.driver);
            loginHelper.Login(username, password);
        }


        [When(@"user click on Login button")]
        public void WhenUserClickOnLoginButton()
        {

            help = new HelperClass(BddHooks.driver);
            help.ButtonClick("Login");
        }

        [Then(@"User can view List of Products ""([^""]*)""")]
        public void ThenUserCanViewListOfProducts(string pRODUCTS)
        {

            productsHelper = new ProductsHelper(BddHooks.driver);
            Boolean flag = productsHelper.Procutsavalability();
            Assert.IsTrue(flag);
        }
       





    }
}
