using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.PageObject;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.ExtensionClass.WebElementExtClass;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.Module.UserGroups
{
    [TestClass]
    public class TestCreateNewGroup :LoginBase
    {
        [TestMethod]
        public void TestCreateGroup()
        {
            try
            {
                // Modify the grp name,row,column accordingly
               // LoginPage lpage = new LoginPage(ObjectRepository.Driver);
               // HomePage hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var mUiPage = HPage.OpenManageUserGroups();
                string name = "Test" + DateTime.UtcNow;
                mUiPage.CreateGroup(name, true);
                mUiPage.VerifyCreateGroup(Properties.Settings.Default.UserGroupGrid, "teststatic", 2, 5);
                mUiPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, "testsmart", 2, 5);
                mUiPage.AddToGroup(Properties.Settings.Default.AllUserGrid, 1, 1);
                mUiPage.DeleteFrmGroup("//div[@id='GroupUsersGrid']", 1, 1);
                mUiPage.ClickSave();
                mUiPage.UsergroupsValidateElements();
                mUiPage.Logout();
                Thread.Sleep(5000);

            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
            
        }
    }
}
