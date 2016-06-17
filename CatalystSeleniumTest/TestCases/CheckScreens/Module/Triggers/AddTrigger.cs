using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Triggers
{
    [TestClass]
    public class Trigger : LoginBase
    {


        [TestMethod]
        public void TriggerScrShot()
        {
            try
            {
                var triPage = HPage.AddTrigger();
                triPage.TakeManageNotificationTriggerScrShot(string.Format("StageTriggers-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
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


