using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ScreenShot
{
    [TestClass]
    public class ProgramPageScreenShot :LoginBase
    {
        /*
        [TestMethod]
        public void ProgramPageSrcShot()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            hPage.TakeHomePageScrShot("Home Page");
            hPage.TakeManageIncentScrShot("Manage Incentive Page");
            hPage.TakeManageClaimsScrShot("Manage Claims");
            hPage.TakeManualPointAdjScrShot("Manual Point Adjustment");
            hPage.TakeManageUserGrpScrShot("Manage User Groups");
            hPage.TakeManageUserScrShot("Manage Users");
            hPage.Logout();
        }

        [TestMethod]
        public void PartnerPageSrcShot()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            hPage.TakeManagePartnerScrShot("Manage Partner");
            hPage.TakePatnerGrpScrShot("Partner Groups");
            hPage.TakeFileLoaderScrShot("File Loader");
            hPage.TakeFileStatusScrShot("File Status");
            hPage.TakeManageNotificationScrShot("Manage Notification Template");
            hPage.TakeManageNotiTriggerScrShot("Manage Notification Trigger");
            hPage.TakeManageSchedMsgScrShot("Manage Schedule Message");
            hPage.TakeEmailAnalyticsScrShot("Email Analytics");
            hPage.TakeReportsScrShot("Reports");
            hPage.Logout();
        }

        [TestMethod]
        public void ConfigurationPageSrcShot()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            hPage.TakeManageRolesScrShot("Manage Roles");
            hPage.TakeCustomeProfScrShot("Custome Profile");
            hPage.TakeCustomeAttributeScrShot("Custome Attribute");
            hPage.TakeManageCustomerContentScrShot("Manage Customer Content");
            hPage.Logout();
        }*/

        [TestMethod]
        public void OnboardingPageSrcShot() 
        {
            try
            {
                // var lpage = new LoginPage(ObjectRepository.Driver);
                // var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                HPage.TakeMyClaimspageScrshot(string.Format("StageMyClaims-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                HPage.TakeprogramspageScrshot(string.Format("StagePrograms-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                // hPage.TakeprogramspagedetailsScrshot("claimdetails");
                HPage.TakeSFDCConfScrShot(string.Format("StageSFDCConfiguration-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.TakePrivacyPolicyScrShot(string.Format("StagePrivacyPolicy-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.TakeTermsConditionScrShot(string.Format("StageTermsandCondition-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.TakeContactUsScrShot(string.Format("StageContactUs-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.TakeFaqScrShot(string.Format("StageFaq-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                HPage.TakeEmailAnalyticsScrShot("Email Analytics");
                //hPage.TakeNewCustomerScrShot("New Customer");

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
