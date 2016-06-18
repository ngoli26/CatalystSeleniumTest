using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.FileManagement
{
    [TestClass]
    public class FileStatus : LoginBase
    {
       

        [TestMethod]
        public void UserFileLoader()
        {
            try
            {
                var filePage = HPage.VerifyFiles();
                filePage.ClickFileNameAndTakeScrShot(string.Format("StageverifyFiles-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
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


