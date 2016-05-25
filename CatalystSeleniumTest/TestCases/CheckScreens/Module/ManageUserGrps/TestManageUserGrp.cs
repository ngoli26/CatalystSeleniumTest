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
            var mPage = HPage.OpenManageUserGroups();
            mPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, "teststatic", 2, 5);
            GenericHelper.TakeSceenShot(string.Format("StageStaticUserGrp-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            mPage.NavigateToHome();
            HPage.OpenManageUserGroups();
            mPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, "testsmart", 1, 5);
            GenericHelper.TakeSceenShot(string.Format("StageSmartUserGrp-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            mPage.Logout();
        }

        [TestMethod]
        public void TestClickCreateAndCancel()
        {
            var mPage = HPage.OpenManageUserGroups();
            mPage.ClickCreateAndCancel(string.Format("StageCreateUserGroup-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            mPage.Logout();
        }

        [TestMethod]
        public void TestCreateGrpOfGrpAndCancel()
        {
            var mPage = HPage.OpenManageUserGroups();
            mPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 1, 1);
            mPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 2, 1);
            mPage.CreateGrpOfGrpAndCancel(string.Format("StageGrpofGrpUserScreenShot-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            mPage.Logout();
        }
    }
}
