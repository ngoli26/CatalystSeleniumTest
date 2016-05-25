using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.ExtensionClass.WebElementExtClass;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ManageRoles
{
    [TestClass]
    public class TestManageRoles :LoginBase
    {
        [TestMethod]
        public void TestManageRolesScreen()
        {
            try
            {
                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var mPage = HPage.ClickManageRoles();
                var rdetailPage = mPage.ClickOnRoleName(Properties.Settings.Default.ManageRolesGrid, 1, 3); // Provide the row and column based on the role name to click
                rdetailPage.ClickSaveWithScreenShot(string.Format("StageRolesDetails 1-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                GenericHelper.WaitForElement(By.XPath(Properties.Settings.Default.ManageRolesGrid));
                rdetailPage = mPage.ClickOnRoleName(Properties.Settings.Default.ManageRolesGrid, 2, 3); // Provide the row and column based on the role name to click
                rdetailPage.ClickSaveWithScreenShot("Roles Details 2");
                rdetailPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
        }

        [TestMethod]
        public void TestCreateAnCancelScrShot()
        {
            try
            {
                //  var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var mPage = HPage.ClickManageRoles();
                var createrole = HPage.ClickManageRoles();
                createrole.ClickCreateAndTakeSrcShot(string.Format("StageCreateRole-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                createrole.Logout();
            }

            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
               
        }
    }

}
