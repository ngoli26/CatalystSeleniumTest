using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ManageUserGrps
{
    [TestClass]
    public class TestManageUserGrp : LoginBase
    {
        [TestMethod]
        public void TestManageUserGrpScreen()
        {
            try
            {
                var mPage = HPage.OpenManageUserGroups();
                mPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, "Claim ", 2, 2);
                GenericHelper.TakeSceenShot(string.Format("StageStaticUserGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                mPage.NavigateToHome();
                HPage.OpenManageUserGroups();
                mPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, "ProdTestSmart ", 7, 2);
                GenericHelper.TakeSceenShot(string.Format("StageSmartUserGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                mPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
           
        }

        [TestMethod]
        public void TestClickCreateAndCancel()
        {
            try
            {
                var mPage = HPage.OpenManageUserGroups();
                mPage.ClickCreateAndCancel(string.Format("StageCreateUserGroup-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                mPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace, exception);
                throw;
            }
           
        }

        [TestMethod]
        public void TestCreateGrpOfGrpAndCancel()
        {
            try
            {
                var mPage = HPage.OpenManageUserGroups();
                mPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 1, 1);
                mPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 2, 1);
                mPage.CreateGrpOfGrpAndCancel(string.Format("StageGrpofGrpUserScreenShot-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                mPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace, exception);
                throw;
            }
            
        }
    }
}
