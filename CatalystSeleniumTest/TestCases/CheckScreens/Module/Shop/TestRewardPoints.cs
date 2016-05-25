using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.Shop
{
    [TestClass]
    public class TestRewardPoints : LoginBase
    {

        [TestMethod, Ignore]
        public void TestRPoints()
        {
            var cPage = HPage.NavigateToCardStore("Card Store"); // supply the name of sub menu item to open
            var vPage = cPage.ClickOpenPrePaid();
            var detailPage = vPage.ClickSelectButton(1); // use this method for selecting the card based on index
            detailPage.SetPointAmount("10"); // to set the point amount
            detailPage.SetQuantity("5"); // to set the quantity
            var rPage = detailPage.ClickAddToBasket(); // Add to Basket action
            //rPage.DeleteFromCart(2); // to delete something from the cart based on index
            //index = 1 will delete the first item
            var shPage = cPage.ClickCheckOut(); // to click on check out button
            //var orPage = shPage.UseThisAddress(1); // use the exisiting address based on index
            shPage.AddExisitngAddress(); // use for adding new adderess and clicking "same as Profile"
            var orPage = shPage.UseThisAddress(1); //After adding the exisiting address you need to call the UseThisAddress(index) method
            // index = 1 will select the first address and so on 
            orPage.PlaceOrder(); // to place the order
            orPage.VerifyOrderConfirmation(); // verify the Thankyou confirmation
            vPage.Logout();
        }
    }
}
