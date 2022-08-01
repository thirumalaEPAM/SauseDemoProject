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

     
        String ItemPrice;
        String Itemname;
        [Then(@"Add First product to Cart")]
        public void ThenAddFirstProductToCart()
        {
            BddHooks.help.ButtonClick(ProductsPage.elementAddCart);
            Itemname = BddHooks.help.GetText(ProductsPage.elementItemName);
            ItemPrice = BddHooks.help.GetText(ProductsPage.elementItemPrice);
            Assert.AreEqual(Constants.remove.ToLower(), BddHooks.help.GetText(ProductsPage.elementRemoveCart));
        }

        [Then(@"Remove Product from Cart")]
        public void ThenRemoveProductFromCart()
        {
            BddHooks.help.ButtonClick(ProductsPage.elementRemoveCart);
            Assert.AreEqual(Constants.addcart.ToLower(), BddHooks.help.GetText(ProductsPage.elementAddCart));
        }

        [Then(@"Validate the Item  and Price of product in Cart page")]
        public void ThenValidateTheItemAndPriceOfProductInCartPage()
        {
            String productPrice = BddHooks.help.GetText(ProductsPage.elementItemPrice);
            String productName = BddHooks.help.GetText(ProductsPage.elementItemName);
            Assert.AreEqual(Itemname, productName);
            Assert.AreEqual(ItemPrice, productPrice);
        }

        [Then(@"Click on checkout and enter the sample details and click continue")]
        public void ThenClickOnCheckoutAndEnterTheSampleDetailsAndClickContinue()
        {
            BddHooks.help.ButtonClick(MyCartPage.elementCheckOut);
            BddHooks.checkoutHelper.userDetailsEntry();
            BddHooks.help.ButtonClick(CheckOutPage.elementContinueBtn);
        }

        [Then(@"Verify the Item and Price on chekout page and click finish")]
        public void ThenVerifyTheItemAndPriceOnChekoutPageAndClickFinish()
        {
            BddHooks.help.ButtonClick(CheckOutPage.elementFinish);
            String expectedMessage = Constants.SuccessMessage;
            String successOrder = BddHooks.help.GetText(CheckOutPage.elementCompleteOrder);
            Assert.AreEqual(expectedMessage, successOrder);
        }
    }
}
