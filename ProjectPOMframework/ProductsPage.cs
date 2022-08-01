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
        public static By elementItemPrice = By.XPath("//div[@class='inventory_item_price']");
        public static By elementItemName = By.XPath("//div[@class='inventory_item_name']");
        public static By elementAddCart = By.XPath("//div[@class='inventory_item_price']//following-sibling::button");
        public static By elementRemoveCart = By.XPath("//button[text()='Remove']");

        //Constants
    }
}
