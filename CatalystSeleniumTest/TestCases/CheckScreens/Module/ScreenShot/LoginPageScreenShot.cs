using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ScreenShot
{
    [TestClass]
    public class LoginPageScreenShot : LoginBase
    {
        [TestMethod]
        public void LoginScrShot()
        {
            try
            {
                Lpage.Logout();
                Lpage.ScreenShotofForgotPassword(string.Format("StageForgotUsername-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                Lpage.ScreenShotofForgotUserName(string.Format("StageForgotPassword-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                Lpage.ScreenShotofOpenReg(string.Format("StageOpenRegister-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
            
        }

    }
}

