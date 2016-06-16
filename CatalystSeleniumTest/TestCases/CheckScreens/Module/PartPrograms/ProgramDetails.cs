using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.PartPrograms
{
    [TestClass]
    public class PartProgramsPageScreenShot:LoginBase
    {
       

        [TestMethod]
        public void PartDetailsPageSrcShot()
        {
            try
            {
                //var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var padetailsPage = HPage.OpenPartDetails();

                padetailsPage.TakeprogramspageScrshot(string.Format("StageParticipantPrograms-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
        }


        [TestMethod]
        public void EligibleProductsPageSrcShot()
        {
            try
            {


                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var padetailsPage = HPage.OpenPartDetails();

                padetailsPage.TakeprogramspagedetailsScrshot(string.Format("StageEligibleProducts-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                HPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }

        }

        [TestMethod]
        public void SubmitOnProgramsPageSrcShot()
        {
            try
            {
                //  var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                var padetailsPage = HPage.OpenPartDetails();

                padetailsPage.TakeSubmitClaimOnProgramsScrshot(string.Format("StageSubmitClaimOnPrograms-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

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


