using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExcelUtility;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Program.ManualPointAdjustment
{
    [TestClass]
    public class TestPointAdjustment : LoginBase
    {
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
