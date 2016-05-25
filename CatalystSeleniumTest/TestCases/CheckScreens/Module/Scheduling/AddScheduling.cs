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


