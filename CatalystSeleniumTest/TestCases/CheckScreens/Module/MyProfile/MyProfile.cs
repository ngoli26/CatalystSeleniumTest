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
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.ExtensionClass.WebElementExtClass;
namespace CatalystSelenium.TestCases.CheckScreens.Module.ManageRoles
{
    [TestClass]
    public class MyProfile :LoginBase
    {
        [TestMethod]
        public void TestMyProfileScreen()
        {
            try
            {
                //var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                HPage.MyProfile();

                GenericHelper.TakeSceenShot(string.Format("StageMyProfile-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }

        }
    }

    [TestClass]
    public class MyTax :LoginBase
    {
        [TestMethod]
        public void TestMyTaxScreen()
        {
            try
            {
                //var lpage = new LoginPage(ObjectRepository.Driver);
                //var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                HPage.MyTax();
                GenericHelper.TakeSceenShot(string.Format("StageMyTax-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.Logout();

            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
        }
    }

    [TestClass]
    public class MyPassword :LoginBase

    {
        [TestMethod]
        public void TestMyPasswordScreen()
        {
            try
            {
                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                HPage.MyPassword();
                GenericHelper.TakeSceenShot(string.Format("StageMyPassword-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
       
        }
    }
}
