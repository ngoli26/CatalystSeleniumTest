using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Users
{
    [TestClass]
    public class UserAccessScreenShot :LoginBase
    {


        [TestMethod]
        public void UserAccessSrcShot()
         {
             try
             {
                 var userPage = HPage.OpenManageUsers();
                 userPage.UpdateUserAccess(string.Format("StageUserAccess-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                 userPage.UserAccessValidateElements();
                 HPage.Logout();
             }
             catch (Exception exception)
             {
                 Logger.Error(exception.StackTrace, exception);
                 throw;
             }
        }

        [TestMethod]
        public void ImpersonateSrcShot()
        {
            try
            {
                var userPage = HPage.OpenManageUsers();
                userPage.ImpersonateUserAccess(string.Format("StageImpersonateUser-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
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


