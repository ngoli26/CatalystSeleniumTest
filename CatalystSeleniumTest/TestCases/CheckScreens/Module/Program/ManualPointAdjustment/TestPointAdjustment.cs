using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExcelUtility;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Program.ManualPointAdjustment
{
    [TestClass]
    public class TestPointAdjustment : LoginBase
    {
        private readonly string[] _manualPointAdjustmentGrid =
        {
            "Email Address", "First Name", "Last Name", "Partner Name", 
            "Job Title", "Job Role", "Preferred Language",
            "City", "State", "Postcode/Zip Code", "Country", "Date Registered", "Active", "Status",
            "Terms and Conditions Accepted Date", "UserCustom", "Shipping Address 1",
            "Shipping Zip", "PostProdDateAttrib"
        };

        [TestMethod]
        [DeploymentItem("Resources")]
        public void TestPointAdjustmentScr()
        {
            
            try
            {
                using (var reader = new ExcelReaderHelper(@"TestData\ManagePartnerGrp.xlsx", "ManualPointAdjustment"))
                {
                    var excelData = reader.GetXcelData();
                    var pAdjPage = HPage.NavigateToManualPointAdjustment();
                    pAdjPage.SelectPointAndProgram(excelData["PointTypes"], excelData["ProgramNames"]); // Provide unique Point Type and Programe Name
                    GenericHelper.WaitForLoadingMask();
                    Thread.Sleep(2000);

                    //Validating the grid header
                    for (var i = 1; i < _manualPointAdjustmentGrid.Length; i++)
                    {
                        Assert.AreEqual(_manualPointAdjustmentGrid[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.ManualPointAdjustmentGrid, 1, (i + 2)));
                    }

                    pAdjPage.SelectPointTypInGrid(Properties.Settings.Default.ManualPointAdjustmentGrid, 1, 1);
                    pAdjPage.ClickPointAdjTakeScrShot(string.Format("ManualPointAdjustment-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                    pAdjPage.ManualPointAdjustmentValidateElements();
                    pAdjPage.Logout();
                }
               
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
            
        }
    }
}
