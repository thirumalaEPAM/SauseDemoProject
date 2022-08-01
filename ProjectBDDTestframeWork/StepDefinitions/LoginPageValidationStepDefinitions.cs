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
       
        [Given(@"Enter the Demo user name ""([^""]*)"" and Password ""([^""]*)""")]
        public void GivenEnterTheDemoUserNameAndPassword(string p0, string p1)
        {
            BddHooks.loginHelper.Login(p0, p1);
        }

        [Given(@"Enter the Demo user name (.*) and Passw (.*)")]
        public void GivenEnterTheDemoAnd(string p0, string p1)
        {
            BddHooks.loginHelper.Login(p0, p1);

        }

            [Given(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string username, string password)
        {
            BddHooks.loginHelper.Login(username, password);
        }


        [When(@"user click on Login button")]
        public void WhenUserClickOnLoginButton()
        {
            BddHooks.help.ButtonClick(LoginPage.elementLogin);
        }

        [Then(@"User can view List of Products ""([^""]*)""")]
        public void ThenUserCanViewListOfProducts(string pRODUCTS)
        {
            Boolean flag = BddHooks.productsHelper.Procutsavalability();
            Assert.IsTrue(flag);
        }
       





    }
}
