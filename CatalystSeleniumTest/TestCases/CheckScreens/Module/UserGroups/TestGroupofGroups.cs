﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.ExtensionClass.WebElementExtClass;

namespace CatalystSelenium.TestCases.Module.UserGroups
{
    [TestClass]
    public class TestGroupofGroups :LoginBase
    {
        [TestMethod]
        public void TestGroup()
        {
            try
            {
                // Modify the grp name,row,column accordingly
                var grpName = "Grp-" + DateTime.UtcNow.ToString("yy-MM-dd-HH-mm");
                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var mUiPage = HPage.OpenManageUserGroups();
                mUiPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 1, 1);
                mUiPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 2, 1);
                mUiPage.CreateGrpOfGroup(grpName, grpName);
                mUiPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
            

        }

    }
}
