using NUnit.Framework;
using ProjectPOMframework;
using ProjectUtilitiesframework;
using System;
using TechTalk.SpecFlow;

namespace ProjectBDDTestframeWork.StepDefinitions
{
    [Binding]
    public class ProductNameAndPriceValidationInAllThePagesStepDefinitions
    {

        HelperClass help;
        ProductsHelper productsHelper;
        CheckoutHelper  checkoutHelper;
        String ItemPrice;
        String Itemname;
        [Then(@"Add First product to Cart")]
        public void ThenAddFirstProductToCart()
        {
            help = new HelperClass(BddHooks.driver);
            help.ButtonClick(Constants.Addcart);
            Itemname = help.getText(Constants.ItemName);
            ItemPrice = help.getText(Constants.Itemprice);
            Assert.AreEqual(Constants.remove.ToLower(), help.getText(Constants.remove).ToLower());
        }

        [Then(@"Remove Product from Cart")]
        public void ThenRemoveProductFromCart()
        {
            help = new HelperClass(BddHooks.driver);
            help.ButtonClick(Constants.remove);
            Assert.AreEqual(Constants.addcart.ToLower(), help.getText(Constants.addcart).ToLower());
        }

        [Then(@"Validate the Item  and Price of product in Cart page")]
        public void ThenValidateTheItemAndPriceOfProductInCartPage()
        {
            help = new HelperClass(BddHooks.driver);
            help.ButtonClick(Constants.shipping);
            String productPrice = help.getText(Constants.Itemprice);
            String productName = help.getText(Constants.ItemName);
            Assert.AreEqual(Itemname, productName);
            Assert.AreEqual(ItemPrice, productPrice);
        }

        [Then(@"Click on checkout and enter the sample details and click continue")]
        public void ThenClickOnCheckoutAndEnterTheSampleDetailsAndClickContinue()
        {
            help = new HelperClass(BddHooks.driver);
            checkoutHelper = new CheckoutHelper(BddHooks.driver);
            help.ButtonClick(Constants.checkout);
            checkoutHelper.userDetailsEntry();
            help.ButtonClick(Constants.Continue);
        }

        [Then(@"Verify the Item and Price on chekout page and click finish")]
        public void ThenVerifyTheItemAndPriceOnChekoutPageAndClickFinish()
        {
            help = new HelperClass(BddHooks.driver);
            help.ButtonClick(Constants.finish);
            String expectedMessage = Constants.SuccessMessage;
            String successOrder = help.getText(Constants.success);
            Assert.AreEqual(expectedMessage, successOrder);
        }
    }
}
