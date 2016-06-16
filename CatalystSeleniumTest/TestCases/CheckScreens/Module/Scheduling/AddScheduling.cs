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
                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var schePage = HPage.AddSchedule();
                schePage.TakeManageSchedulingScrShot(string.Format("StageManageScheduledMessages-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                //schePage.ChooseTemplate("SelectTemplate");
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


