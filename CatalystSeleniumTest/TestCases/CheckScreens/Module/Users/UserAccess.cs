using System;
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

namespace CatalystSelenium.TestCases.Module.ScreenShot
{
    [TestClass]
    public class UserAccessScreenShot :LoginBase
    {
       

        [TestMethod]
        public void UserAccessSrcShot()
         {
             try
             {
                 //var lpage = new LoginPage(ObjectRepository.Driver);
                 // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                 var userPage = HPage.OpenManageUsers();

                 userPage.UpdateUserAccess(string.Format("StageUserAccess-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                 userPage.UserAccessValidateElements();

                 HPage.Logout();
             }
             catch (Exception exception)
             {
                 Logger.LogException(exception);
                 throw;
             }
        }

        [TestMethod]
        public void ImpersonateSrcShot()
        {
            try
            {
                //  var lpage = new LoginPage(ObjectRepository.Driver);
                //  var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());

                var userPage = HPage.OpenManageUsers();

                userPage.ImpersonateUserAccess(string.Format("StageImpersonateUser-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

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


