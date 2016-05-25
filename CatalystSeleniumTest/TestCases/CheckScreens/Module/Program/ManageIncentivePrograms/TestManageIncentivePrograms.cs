using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.ScreenShotExtClass;
using CatalystSelenium.PageObject.IncentivePage;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Program.ManageIncentivePrograms
{
    [TestClass]
    public class TestManageIncentivePrograms : LoginBase
    {
        [TestMethod]
        public void TestManageIncentiveProgramsScr()
        {
            var pAdjPage = HPage.OpenManageIncentivePrograms();
            pAdjPage.SelectItemPerList("100");
            pAdjPage.CaptureScreenShot();
            pAdjPage.ClickElemetInGrid(Properties.Settings.Default.ManageIncentiveProgramsGrid,9,1);
            pAdjPage.SelectProgramNameClickNext();
            pAdjPage.SelectProgramDatesClickNext();
            pAdjPage.SelectConfigurePrgsClickNext();
            pAdjPage.SelectProgramIncetiveClickNext();
            pAdjPage.SelectEligibelGrpClickNext();
            pAdjPage.SelectValidationClickNext();
            pAdjPage.SelectBundelSetupClickNext();
            pAdjPage.SelectOverlaySetupClickNext();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.XPath("//button[text()='Finish']"));
            GenericHelper.WaitForLoadingMask();
            ButtonHelper.ClickButton(By.XPath("//button[text()='Finish']"));
            GenericHelper.WaitForLoadingMask();
            pAdjPage.Logout();
        }
    }
}
