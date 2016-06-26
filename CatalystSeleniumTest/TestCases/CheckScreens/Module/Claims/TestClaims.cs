using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Claims
{
    [TestClass]
    public class TestClaims : LoginBase
    {
        [TestMethod]
        public void TestNewClaim()
        {
            try
            {
                var clPage = HPage.OpeNewClaimPage();
                clPage.SelectNewClaim("Test expire");
                clPage.InsertNumber("10", "10", "11", "12"); // pass null if field is not at page
                clPage.SelectOrderDate("10", "April", "2014"); // Do not call if field is not at page
                clPage.SelectBillDate("11", "April", "2015"); // Do not call if field is not at page
                clPage.SelectShipDate("12", "April", "2015"); // Do not call if field is not at page
                clPage.SelectInvoiceDate("11", "April", "2015"); // Do not call if field is not at page
                clPage.InsertEmpPoInvoiceNo("1", "1", "122"); // pass null if field is not at page
                clPage.EnterProductDetails("SKU1", "1", "1");
                //GridHelper.VerifyInGridEntry(Properties.Settings.Default.ClaimDataGrid, "SKU1", 1,1); // verify in gird Similarly for other column
                // clPage.ClickVerifyBtnInGrid(Properties.Settings.Default.ClaimDataGrid,1,7); // for Verify button in grid
                //clPage.ClickDeleteBtnInGrid(Properties.Settings.Default.ClaimDataGrid,1,8); // for delete button in grid
                //clPage.VerifyEstimatedTotalPts("100"); // for verifying the total esmt points
                var claimNo = clPage.SubmitClaim(); // will give u the claim no
                Console.WriteLine("Claim No is : {0}", claimNo);
                clPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
            
        }
    }
}
