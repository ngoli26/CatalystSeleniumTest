using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExcelUtility;
using CatalystSelenium.ExtensionClass.ScreenShotExtClass;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Program.ManageCalims
{
    [TestClass]
    public class TestManageCalims : LoginBase
    {
        [TestMethod]
        [DeploymentItem("Resources")]
        public void TestManageCalimsScr()
        {
            try
            {
                using (var reader = new ExcelReaderHelper(@"TestData\ManagePartnerGrp.xlsx", "ManageClaims"))
                {
                    var excelData = reader.GetXcelData();
                    var mclaimPage = HPage.OpeManageCalimsPage();
                    mclaimPage.SelectProgram(excelData["ProgramName"]);
                    mclaimPage.CaptureScreenShot(string.Format("ProgramName-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                    mclaimPage.ClickViewInGrid(Properties.Settings.Default.ManualApprovalGrid, 1);
                    mclaimPage.ValidateAllElements(); // Method for validation
                    mclaimPage.CaptureScreenShot(string.Format("ProgramNameView-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                    mclaimPage.ClickAddProductAndTakeScrShot(string.Format("AddEditProduct-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                    mclaimPage.Logout();
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
