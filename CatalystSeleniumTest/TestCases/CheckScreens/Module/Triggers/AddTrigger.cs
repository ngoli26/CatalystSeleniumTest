using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.PageObject;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.ExtensionClass.WebElementExtClass;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.Module.ScreenShot
{
    [TestClass]
    public class Trigger : LoginBase
    {
       

        [TestMethod]
        public void TriggerScrShot()
        {
            try
            {
                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                Logger.Info("Clicking on the Manage Trigger");
                var triPage = HPage.AddTrigger();
                triPage.TakeManageNotificationTriggerScrShot(string.Format("StageTriggers-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                // hPage.Logout();
            }

            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
        }
       


    }
}


