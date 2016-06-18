using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Scheduling
{
    [TestClass]
    public class Schedule :LoginBase
    {
       

        [TestMethod]
        public void ScheduleScrShot()
        {
            try
            {
                var schePage = HPage.AddSchedule();
                schePage.TakeManageSchedulingScrShot(string.Format("StageManageScheduledMessages-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
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


