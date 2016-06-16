using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Partner
{
    [TestClass]
    public class PartnerPageScreenShot :LoginBase
    {
       

        [TestMethod]
        public void PartnerPageSrcShot()
        {
            try
            {
                var paPage = HPage.OpenManagePartners();

                paPage.TakeManagePartnerScrShot(string.Format("StageManagePartner-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                paPage.TakePartnerprofile(string.Format("StagePartProfile-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                paPage.PartnerValidateElements();
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


