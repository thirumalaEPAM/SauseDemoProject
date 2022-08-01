using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOMframework
{
    public class ProductsPage
    {
        //Web Elements declaration
        public By elementItemPrice = By.XPath("//div[@class='inventory_item_price']");
        public By elementItemName = By.XPath("//div[@class='inventory_item_name']");
        public By elementAddCart = By.XPath("//div[@class='inventory_item_price']//following-sibling::button");
        public By elementRemoveCart = By.XPath("//button[text()='Remove']");


        //Constants
    }
}
