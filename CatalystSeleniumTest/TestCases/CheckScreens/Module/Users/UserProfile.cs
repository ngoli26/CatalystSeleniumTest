using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Users
{
    [TestClass]
    public class UserProfileScreenShot : LoginBase
    {


        [TestMethod]
        public void UserProfileSrcShot()
         {
             try
             {
                 var userPage = HPage.OpenManageUsers();
                 userPage.TakeUserprofile(string.Format("StageEditUserProfile-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                 userPage.UserProfileValidateElements();
                 HPage.Logout();
             }
             catch (Exception exception)
             {
                 Logger.Error(exception.StackTrace, exception);
                 throw;
             }
        }
       


    }
}


