using System;
using System.Threading;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Users
{
    [TestClass]
    public class UserProfileScreenShot : LoginBase
    {

        private readonly string[] _manageUserGrid =
        {
            "Actions", "Email Address", "User Name", "First Name", "Last Name", "Partner Name", "Partner Number",
            "Job Title", "Job Role", "Preferred Language",
            "City", "State", "Postcode/Zip Code", "Country", "Date Registered", "Active", "SSO",
            "Terms and Conditions Accepted Date", "UserCustom", "Shipping Address 1",
            "Shipping Zip", "PostProdDateAttrib"
        };

        private readonly string[] _pendingUserGrid =
        {
            "Actions", "Email Address", "User Name", "First Name", "Last Name", "Partner Name", "Partner Number",
            "Job Title", "Job Role", "Preferred Language",
            "City", "State", "Postcode/Zip Code", "Country", "Date Registered", "Active", "Status",
            "Terms and Conditions Accepted Date", "UserCustom", "Shipping Address 1",
            "Shipping Zip", "PostProdDateAttrib"
        };

        [TestMethod]
        public void UserProfileSrcShot()
         {
             try
             {
                 var userPage = HPage.OpenManageUsers();

                 //Validating the grid header
                 for (var i = 1; i < _manageUserGrid.Length; i++)
                 {
                     Assert.AreEqual(_manageUserGrid[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.UserGrid, 1, (i + 2)));
                 }

                 userPage.TakeUserprofile(string.Format("StageEditUserProfile-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                 userPage.UserProfileValidateElements();
                 userPage.Pendingusers.Click();
                 Thread.Sleep(2000);
                 GenericHelper.WaitForLoadingMask();

                 //Validating the grid header
                 for (var i = 1; i < _pendingUserGrid.Length; i++)
                 {
                     Assert.AreEqual(_pendingUserGrid[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.PendingUserGrid, 1, (i + 2)));
                 }

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


