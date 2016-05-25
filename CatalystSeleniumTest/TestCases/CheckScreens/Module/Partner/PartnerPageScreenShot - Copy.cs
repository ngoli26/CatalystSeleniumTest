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
    public class PartnerPageScreenShot :LoginBase
    {
       

        [TestMethod]
        public void PartnerPageSrcShot()
        {
            try
            {
                //var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
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


