using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.CustomerProfile
{
    [TestClass]
    public class CustomerpRofile : LoginBase
    {
       

        [TestMethod]
        public void CustprofileScrShot()
        {

            try
            {
                var custpage = HPage.SaveCustomerProfile();

                custpage.TakeCustomerPorfileScrShot(string.Format("StageCustomerProfile-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                custpage.CustProfileValidateElements();
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


