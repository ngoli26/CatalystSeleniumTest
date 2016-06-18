using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.MyProfile
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
                Logger.Error(exception.StackTrace,exception);
                throw;
            }

        }
    }

    [TestClass]
    public class MyTax : LoginBase
    {
        [TestMethod]
        public void TestMyTaxScreen()
        {
            try
            {
                HPage.MyTax();
                GenericHelper.TakeSceenShot(string.Format("StageMyTax-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.Logout();

            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
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
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
       
        }
    }
}
