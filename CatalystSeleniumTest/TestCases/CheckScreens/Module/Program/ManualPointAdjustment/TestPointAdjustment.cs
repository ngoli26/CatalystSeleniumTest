using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Program.ManualPointAdjustment
{
    [TestClass]
    public class TestPointAdjustment : LoginBase
    {
        [TestMethod]
        public void TestPointAdjustmentScr()
        {
            var pAdjPage = HPage.NavigateToManualPointAdjustment();
            pAdjPage.SelectPointAndProgram("test", "Test activity"); // Provide unique Point Type and Programe Name
            pAdjPage.SelectPointTypInGrid(Properties.Settings.Default.ManualPointAdjustmentGrid,1,1);
            pAdjPage.ClickPointAdjTakeScrShot(string.Format("ManualPointAdjustment-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            pAdjPage.ManualPointAdjustmentValidateElements();
            pAdjPage.Logout();
        }
    }
}
