using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ManagePartnerGrp
{
    [TestClass]
    public class TestManagePartnerGrp : LoginBase
    {
        [TestMethod]
        public void TestManagePartnerGrpScr()
        {
            try
            {
                var partPage = HPage.ClickManagePartnerGrp();
                partPage.ValidateElement();
                partPage.ClickOnUserGrp(Properties.Settings.Default.PartenrGrpGrid, "test", 1, 2);
                GenericHelper.TakeSceenShot(string.Format("StagePartnerStaticGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                partPage.NavigateToHome();
                partPage = HPage.ClickManagePartnerGrp();
                partPage.ClickOnUserGrp(Properties.Settings.Default.PartenrGrpGrid, "test1", 2, 2);
                GenericHelper.TakeSceenShot(string.Format("StagePartnerSmartGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                partPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace, exception);
                throw;
            }
            

        }

        [TestMethod]
        public void TestCreateAnCancelScrShot()
        {
            try
            {
                var partPage = HPage.ClickManagePartnerGrp();
                partPage.ClickCreateAndTakeSrcShot(string.Format("StageCreatePartnerGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                partPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
           
        }

        [TestMethod]
        public void TestCreateGrpOfGrpAndCancel()
        {
            try
            {
                var partPage = HPage.ClickManagePartnerGrp();
                partPage.SelectGroup(Properties.Settings.Default.PartenrGrpGrid, 1, 1);
                partPage.SelectGroup(Properties.Settings.Default.PartenrGrpGrid, 2, 1);
                partPage.CreateGrpOfGrpAndCancel(string.Format("StagePartnerGrpofGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                partPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace, exception);
                throw;
            }
            
        }

    }
}
