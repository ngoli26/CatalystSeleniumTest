using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.ScreenShotExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Shop
{
    [TestClass]
    public class TestMyOrders : LoginBase
    {
        [TestMethod,Ignore]
        public void TestMethodMyOrders()
        {
            try
            {
                var cPage = HPage.NavigateToOrders();
                DropDownHelper.SelectItemPerList("100"); // used to select the 100 item in the grid
                cPage.ClickViewInGrid(1, 7); // supply the row and column to clcik on view button of the order
                cPage.VerifyOrderNumber("Order Number: 215"); // should specify in this format "Order Number: 215", "Order Number: 216", "Order Number: 210" so on.
                cPage.VerifyOrderDate("Order Date: Jan 20, 2016"); // should specify in this format "Order Date: Jan 20, 2016", "Order Date: Jan 21, 2016", "Order Date: Jan 20, 2017" so on.
                cPage.CaptureScreenShot(); // will take the screen shot
                cPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
           
        }
    }
}
