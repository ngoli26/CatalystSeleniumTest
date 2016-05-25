using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.ScreenShotExtClass;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Program.ManageCalims
{
    [TestClass]
    public class TestManageCalims : LoginBase
    {
       // [TestMethod]
        [TestMethod, Ignore]
        public void TestManageCalimsScr()
        {
            var mclaimPage = HPage.OpeManageCalimsPage();
            mclaimPage.SelectProgram("Test expire");
            mclaimPage.CaptureScreenShot(string.Format("ProgramName-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            mclaimPage.ClickViewInGrid(Properties.Settings.Default.ManualApprovalGrid,1);
            mclaimPage.ValidateAllElements(); // Method for validation
            mclaimPage.CaptureScreenShot(string.Format("ProgramNameView-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            mclaimPage.ClickAddProductAndTakeScrShot(string.Format("AddEditProduct-{ 0}",DateTime.UtcNow.ToString("hh-mm-ss")));
          //  mclaimPage.Logout();
        }

    }
}
