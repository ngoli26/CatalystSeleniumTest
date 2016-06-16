using System;
using System.Threading;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.UserGroups
{
    [TestClass]
    public class TestDuplicateGrp :LoginBase
    {
        [TestMethod]
        public void TestDuplicateGrps()
        {
            try
            {
                // Modify the grp name,row,column accordingly
                // LoginPage lpage = new LoginPage(ObjectRepository.Driver);
                // HomePage hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var mUiPage = HPage.OpenManageUserGroups();
                mUiPage.DuplicateGrp("//div[@id='UserGroupsGrid']", 1, 1);
                //  mUiPage.VerifyCreateGroup("//div[@id='UserGroupsGrid']", "Test11/11/2015 5:34:13 PM", 3,2);
                // mUiPage.ClickOnUserGrp("//div[@id='UserGroupsGrid']", "StaticStage1", 2, 2);
                // mUiPage.AddToGroup("//div[@id='allUsersGrid']", 1, 1);
                //mUiPage.DeleteFrmGroup("//div[@id='GroupUsersGrid']", 1, 1);
                //mUiPage.ClickSave();
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
